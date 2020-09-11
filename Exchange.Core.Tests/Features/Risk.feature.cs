﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Exchange.Core.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("An exchange should not allow to users to submit orders which break their limits")]
    public partial class AnExchangeShouldNotAllowToUsersToSubmitOrdersWhichBreakTheirLimitsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Risk.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "An exchange should not allow to users to submit orders which break their limits", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("basic scenario")]
        [NUnit.Framework.CategoryAttribute("BasicRiskCheck")]
        public virtual void BasicScenario()
        {
            string[] tagsOfScenario = new string[] {
                    "BasicRiskCheck"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("basic scenario", null, tagsOfScenario, argumentsOfScenario);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "2000000"});
#line 5
 testRunner.Given("New client Alice has a balance:", ((string)(null)), table13, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "699999"});
#line 7
 testRunner.And("New client Bob has a balance:", ((string)(null)), table14, "And ");
#line hidden
#line 9
 testRunner.When("A client Alice could not place an BID order 101 at 30000@7 (type: GTC, symbol: ET" +
                        "H_XBT, reservePrice: 30000) due to RISK_NSF", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "2000000"});
#line 10
 testRunner.Then("A balance of a client Alice:", ((string)(null)), table15, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
#line 12
 testRunner.And("A client Alice orders:", ((string)(null)), table16, "And ");
#line hidden
#line 14
 testRunner.Given("100000 XBT is added to the balance of a client Alice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
 testRunner.When("A client Alice places an BID order 101 at 30000@7 (type: GTC, symbol: ETH_XBT, re" +
                        "servePrice: 30000)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "bid",
                            "price",
                            "ask"});
                table17.AddRow(new string[] {
                            "7",
                            "30000",
                            ""});
#line 16
 testRunner.Then("An ETH_XBT order book is:", ((string)(null)), table17, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "0"});
#line 19
 testRunner.And("A balance of a client Alice:", ((string)(null)), table18, "And ");
#line hidden
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
                table19.AddRow(new string[] {
                            "101",
                            "30000",
                            "7",
                            "0",
                            "30000",
                            "BID"});
#line 21
 testRunner.And("A client Alice orders:", ((string)(null)), table19, "And ");
#line hidden
#line 24
 testRunner.When("A client Bob could not place an ASK order 102 at 30000@7 (type: IOC, symbol: ETH_" +
                        "XBT, reservePrice: 30000) due to RISK_NSF", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "699999"});
#line 25
 testRunner.Then("A balance of a client Bob:", ((string)(null)), table20, "Then ");
#line hidden
#line 27
 testRunner.And("A client Bob does not have active orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Given("1 ETH is added to the balance of a client Bob", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 29
 testRunner.When("A client Bob places an ASK order 102 at 30000@7 (type: IOC, symbol: ETH_XBT, rese" +
                        "rvePrice: 30000)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("The order 101 is fully matched. LastPx: 30000, LastQty: 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "700000"});
#line 31
 testRunner.And("A balance of a client Alice:", ((string)(null)), table21, "And ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "2100000"});
#line 33
 testRunner.And("A balance of a client Bob:", ((string)(null)), table22, "And ");
#line hidden
#line 35
 testRunner.And("A client Alice does not have active orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("A client Bob does not have active orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("move orders UP and DOWN")]
        [NUnit.Framework.CategoryAttribute("MoveOrdersUpAndDown")]
        public virtual void MoveOrdersUPAndDOWN()
        {
            string[] tagsOfScenario = new string[] {
                    "MoveOrdersUpAndDown"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("move orders UP and DOWN", null, tagsOfScenario, argumentsOfScenario);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "100000000"});
#line 40
 testRunner.Given("New client Alice has a balance:", ((string)(null)), table23, "Given ");
#line hidden
#line 42
 testRunner.When("A client Alice could not place an ASK order 202 at 30000@1001 (type: GTC, symbol:" +
                        " ETH_XBT, reservePrice: 30000) due to RISK_NSF", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "100000000"});
#line 43
 testRunner.Then("A balance of a client Alice:", ((string)(null)), table24, "Then ");
#line hidden
#line 45
 testRunner.And("A client Alice does not have active orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.When("A client Alice places an ASK order 202 at 30000@1000 (type: GTC, symbol: ETH_XBT," +
                        " reservePrice: 30000)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "0"});
#line 47
 testRunner.Then("A balance of a client Alice:", ((string)(null)), table25, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
                table26.AddRow(new string[] {
                            "202",
                            "30000",
                            "1000",
                            "0",
                            "30000",
                            "ASK"});
#line 49
 testRunner.And("A client Alice orders:", ((string)(null)), table26, "And ");
#line hidden
#line 52
 testRunner.When("A client Alice moves a price to 40000 of the order 202", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "0"});
#line 53
 testRunner.Then("A balance of a client Alice:", ((string)(null)), table27, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
                table28.AddRow(new string[] {
                            "202",
                            "40000",
                            "1000",
                            "0",
                            "30000",
                            "ASK"});
#line 55
 testRunner.And("A client Alice orders:", ((string)(null)), table28, "And ");
#line hidden
#line 58
 testRunner.When("A client Alice moves a price to 20000 of the order 202", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "0"});
#line 59
 testRunner.Then("A balance of a client Alice:", ((string)(null)), table29, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
                table30.AddRow(new string[] {
                            "202",
                            "20000",
                            "1000",
                            "0",
                            "30000",
                            "ASK"});
#line 61
 testRunner.And("A client Alice orders:", ((string)(null)), table30, "And ");
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "94000000"});
#line 64
 testRunner.Given("New client Bob has a balance:", ((string)(null)), table31, "Given ");
#line hidden
#line 66
 testRunner.When("A client Bob could not place an BID order 203 at 18000@500 (type: GTC, symbol: ET" +
                        "H_XBT, reservePrice: 19000) due to RISK_NSF", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "94000000"});
#line 67
 testRunner.Then("A balance of a client Bob:", ((string)(null)), table32, "Then ");
#line hidden
#line 69
 testRunner.And("A client Bob does not have active orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.When("A client Bob places an BID order 203 at 18000@500 (type: GTC, symbol: ETH_XBT, re" +
                        "servePrice: 18500)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("No trade events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "20000",
                            "1000"});
                table33.AddRow(new string[] {
                            "500",
                            "18000",
                            ""});
#line 72
 testRunner.And("An ETH_XBT order book is:", ((string)(null)), table33, "And ");
#line hidden
                TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "1500000"});
#line 75
 testRunner.And("A balance of a client Bob:", ((string)(null)), table34, "And ");
#line hidden
                TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
                table35.AddRow(new string[] {
                            "203",
                            "18000",
                            "500",
                            "0",
                            "18500",
                            "BID"});
#line 77
 testRunner.And("A client Bob orders:", ((string)(null)), table35, "And ");
#line hidden
#line 80
 testRunner.When("A client Bob could not move a price to 18501 of the order 203 due to MATCHING_MOV" +
                        "E_FAILED_PRICE_OVER_RISK_LIMIT", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "1500000"});
#line 81
 testRunner.Then("A balance of a client Bob:", ((string)(null)), table36, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
                table37.AddRow(new string[] {
                            "203",
                            "18000",
                            "500",
                            "0",
                            "18500",
                            "BID"});
#line 83
 testRunner.And("A client Bob orders:", ((string)(null)), table37, "And ");
#line hidden
                TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "20000",
                            "1000"});
                table38.AddRow(new string[] {
                            "500",
                            "18000",
                            ""});
#line 86
 testRunner.And("An ETH_XBT order book is:", ((string)(null)), table38, "And ");
#line hidden
#line 89
 testRunner.When("A client Bob moves a price to 18500 of the order 203", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "1500000"});
#line 90
 testRunner.Then("A balance of a client Bob:", ((string)(null)), table39, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "20000",
                            "1000"});
                table40.AddRow(new string[] {
                            "500",
                            "18500",
                            ""});
#line 92
 testRunner.And("An ETH_XBT order book is:", ((string)(null)), table40, "And ");
#line hidden
#line 95
 testRunner.When("A client Bob moves a price to 17500 of the order 203", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "1500000"});
#line 96
 testRunner.Then("A balance of a client Bob:", ((string)(null)), table41, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "20000",
                            "1000"});
                table42.AddRow(new string[] {
                            "500",
                            "17500",
                            ""});
#line 98
 testRunner.And("An ETH_XBT order book is:", ((string)(null)), table42, "And ");
#line hidden
#line 101
 testRunner.When("A client Alice moves a price to 16900 of the order 202", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.Then("The order 203 is fully matched. LastPx: 17500, LastQty: 500, bidderHoldPrice: 185" +
                        "00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "0"});
                table43.AddRow(new string[] {
                            "XBT",
                            "87500000"});
#line 103
 testRunner.And("A balance of a client Alice:", ((string)(null)), table43, "And ");
#line hidden
                TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                            "id",
                            "price",
                            "size",
                            "filled",
                            "reservePrice",
                            "side"});
                table44.AddRow(new string[] {
                            "202",
                            "16900",
                            "1000",
                            "500",
                            "30000",
                            "ASK"});
#line 106
 testRunner.And("A client Alice orders:", ((string)(null)), table44, "And ");
#line hidden
                TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "16900",
                            "500"});
#line 109
 testRunner.And("An ETH_XBT order book is:", ((string)(null)), table45, "And ");
#line hidden
                TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                            "XBT",
                            "6500000"});
                table46.AddRow(new string[] {
                            "ETH",
                            "50000000"});
#line 111
 testRunner.Then("A balance of a client Bob:", ((string)(null)), table46, "Then ");
#line hidden
#line 114
 testRunner.And("A client Bob does not have active orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.When("A client Alice cancels the remaining size 500 of the order 202", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                            "ETH",
                            "50000000"});
                table47.AddRow(new string[] {
                            "XBT",
                            "87500000"});
#line 116
 testRunner.Then("A balance of a client Alice:", ((string)(null)), table47, "Then ");
#line hidden
#line 119
 testRunner.And("A client Alice does not have active orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
