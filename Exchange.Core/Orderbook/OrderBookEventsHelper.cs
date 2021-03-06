﻿using Exchange.Core.Common;
using Exchange.Core.Utils;
using OpenHFT.Chronicle.WireMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Core.Orderbook
{
    public sealed class OrderBookEventsHelper
    {
        public static readonly OrderBookEventsHelper NON_POOLED_EVENTS_HELPER = new OrderBookEventsHelper(() => new MatcherTradeEvent());

        private readonly Func<MatcherTradeEvent> eventChainsSupplier;

        private MatcherTradeEvent eventsChainHead;

        public OrderBookEventsHelper(Func<MatcherTradeEvent> factory)
        {
            eventChainsSupplier = factory;
        }

        public MatcherTradeEvent sendTradeEvent(IOrder matchingOrder,
                                                bool makerCompleted,
                                                bool takerCompleted,
                                                long size,
                                                long bidderHoldPrice)
        {
            //final long takerOrderTimestamp

            //        log.debug("** sendTradeEvent: active id:{} matched id:{}", activeOrder.orderId, matchingOrder.orderId);
            //        log.debug("** sendTradeEvent: price:{} v:{}", price, v);

            MatcherTradeEvent evnt = newMatcherEvent();

            evnt.EventType = MatcherEventType.TRADE;
            evnt.Section = 0;

            evnt.ActiveOrderCompleted = takerCompleted;

            evnt.MatchedOrderId = matchingOrder.OrderId;
            evnt.MatchedOrderUid = matchingOrder.Uid;
            evnt.MatchedOrderCompleted = makerCompleted;

            evnt.Price = matchingOrder.Price;
            evnt.Size = size;

            // set order reserved price for correct released EBids
            evnt.BidderHoldPrice = bidderHoldPrice;

            return evnt;

        }

        public MatcherTradeEvent sendReduceEvent(IOrder order, long reduceSize, bool completed)
        {
            //        log.debug("Cancel ");
            MatcherTradeEvent evnt = newMatcherEvent();
            evnt.EventType = MatcherEventType.REDUCE;
            evnt.Section = 0;
            evnt.ActiveOrderCompleted = completed;
            //        evnt.activeOrderSeq = order.seq;
            evnt.MatchedOrderId = 0;
            evnt.MatchedOrderCompleted = false;
            evnt.Price = order.Price;
            //        evnt.size = order.getSize() - order.getFilled();
            evnt.Size = reduceSize;

            evnt.BidderHoldPrice = order.ReserveBidPrice; // set order reserved price for correct released EBids

            return evnt;
        }


        public void attachRejectEvent(OrderCommand cmd, long rejectedSize)
        {

            //        log.debug("Rejected {}", cmd.orderId);
            //        log.debug("\n{}", getL2MarketDataSnapshot(10).dumpOrderBook());

            MatcherTradeEvent evnt = newMatcherEvent();

            evnt.EventType = MatcherEventType.REJECT;

            evnt.Section = 0;

            evnt.ActiveOrderCompleted = true;
            //        evnt.activeOrderSeq = cmd.seq;

            evnt.MatchedOrderId = 0;
            evnt.MatchedOrderCompleted = false;

            evnt.Price = cmd.Price;
            evnt.Size = rejectedSize;

            evnt.BidderHoldPrice = cmd.ReserveBidPrice; // set command reserved price for correct released EBids

            // insert event
            evnt.NextEvent = cmd.MatcherEvent;
            cmd.MatcherEvent = evnt;
        }

        public MatcherTradeEvent createBinaryEventsChain(long timestamp,
                                                         int section,
                                                         NativeBytes bytes)
        {

            long[] dataArray = SerializationUtils.bytesToLongArray(bytes, 5);

            MatcherTradeEvent firstEvent = null;
            MatcherTradeEvent lastEvent = null;
            for (int i = 0; i < dataArray.Length; i += 5)
            {

                MatcherTradeEvent evnt = newMatcherEvent();

                evnt.EventType = MatcherEventType.BINARY_EVENT;

                evnt.Section = section;
                evnt.MatchedOrderId = dataArray[i];
                evnt.MatchedOrderUid = dataArray[i + 1];
                evnt.Price = dataArray[i + 2];
                evnt.Size = dataArray[i + 3];
                evnt.BidderHoldPrice = dataArray[i + 4];

                evnt.NextEvent = null;

                //            log.debug("BIN EVENT: {}", event);

                // attach in direct order
                if (firstEvent == null)
                {
                    firstEvent = evnt;
                }
                else
                {
                    lastEvent.NextEvent = evnt;
                }
                lastEvent = evnt;
            }

            return firstEvent;
        }


        public static SortedDictionary<int, Wire> deserializeEvents(OrderCommand cmd)
        {

            Dictionary<int, List<MatcherTradeEvent>> sections = new Dictionary<int, List<MatcherTradeEvent>>();
            cmd.processMatcherEvents(evt =>
            {
                //sections.computeIfAbsent(evt.section, k => new ArrayList<>()).add(evt);
                if (!sections.TryGetValue(evt.Section, out List<MatcherTradeEvent> value))
                {
                    value = new List<MatcherTradeEvent>();
                    sections[evt.Section] = value;
                }
                value.Add(evt);
            });

            SortedDictionary<int, Wire> result = new SortedDictionary<int, Wire>();

            foreach (var pair in sections)
            {
                var section = pair.Key;
                var events = pair.Value;
                long[] dataArray = events.SelectMany(evt => new[]
                {
                    evt.MatchedOrderId,
                                evt.MatchedOrderUid,
                                evt.Price,
                                evt.Size,
                                evt.BidderHoldPrice
                }).ToArray();

                Wire wire = SerializationUtils.longsToWire(dataArray);

                result[section] = wire;

            }

            return result;
        }

        private MatcherTradeEvent newMatcherEvent()
        {

            if (ExchangeCore.EVENTS_POOLING)
            {
                if (eventsChainHead == null)
                {
                    eventsChainHead = eventChainsSupplier();
                    //            log.debug("UPDATED HEAD size={}", eventsChainHead == null ? 0 : eventsChainHead.getChainSize());
                }
                MatcherTradeEvent res = eventsChainHead;
                eventsChainHead = eventsChainHead.NextEvent;
                return res;
            }
            else
            {
                return new MatcherTradeEvent();
            }
        }

    }
}
