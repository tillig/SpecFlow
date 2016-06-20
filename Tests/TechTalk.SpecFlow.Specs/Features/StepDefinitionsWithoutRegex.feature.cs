﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Step definitions can be matched based on the method name (without Regex)")]
    public partial class StepDefinitionsCanBeMatchedBasedOnTheMethodNameWithoutRegexFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StepDefinitionsWithoutRegex.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Step definitions can be matched based on the method name (without Regex)", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parameterless steps")]
        public virtual void ParameterlessSteps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parameterless steps", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 4
 testRunner.Given("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("the following step definitions", "[When]\r\npublic void When_I_do_something()\r\n{}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("the binding method \'When_I_do_something\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void StepsWithParameters(string @case, string parameter, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with parameters", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 18
 testRunner.Given("a scenario \'Simple Scenario\' as", string.Format("When {0} does something", parameter), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.And("the following step definitions", "[When]\r\npublic void When_WHO_does_something(string who)\r\n{\r\n\tif (who != \"Joe\") th" +
                    "row new Exception(\"invalid parameter: \" + who);\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("the binding method \'When_WHO_does_something\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters: simple")]
        public virtual void StepsWithParameters_Simple()
        {
            this.StepsWithParameters("simple", "Joe", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters: quoted")]
        public virtual void StepsWithParameters_Quoted()
        {
            this.StepsWithParameters("quoted", "\"Joe\"", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters: apostrophed")]
        public virtual void StepsWithParameters_Apostrophed()
        {
            this.StepsWithParameters("apostrophed", "\'Joe\'", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters referred by index")]
        public virtual void StepsWithParametersReferredByIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with parameters referred by index", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 40
 testRunner.Given("a scenario \'Simple Scenario\' as", "When Joe does something with:", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
 testRunner.And("the following step definitions", "[When]\r\npublic void When_P0_does_P1_with(string who, string what)\r\n{\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("the binding method \'When_P0_does_P1_with\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with multiple parameters and punctuation")]
        public virtual void StepsWithMultipleParametersAndPunctuation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with multiple parameters and punctuation", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 56
 testRunner.Given("a scenario \'Simple Scenario\' as", "When Joe does - something with:\r\n| table |", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 61
 testRunner.And("the following step definitions", "[When]\r\npublic void When_WHO_does_WHAT_with(string who, string what, Table table)" +
                    "\r\n{\r\n\tif (what != \"something\") throw new Exception(\"invalid parameter: \" + what)" +
                    ";\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("the binding method \'When_WHO_does_WHAT_with\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Keyword prefix can be omitted")]
        public virtual void KeywordPrefixCanBeOmitted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Keyword prefix can be omitted", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 74
 testRunner.Given("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 78
 testRunner.And("the following step definitions", "[When] public void I_do_something()\r\n{}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("the binding method \'I_do_something\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void SupportsAllAttributes(string attribute, string step, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Supports all attributes", exampleTags);
#line 87
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 88
 testRunner.Given("a scenario \'Simple Scenario\' as", string.Format("{0} I do something", step), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 92
 testRunner.And("the following step definitions", string.Format("[{0}] public void I_do_something()\r\n{{}}", attribute), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.Then("the binding method \'I_do_something\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes: Given")]
        public virtual void SupportsAllAttributes_Given()
        {
            this.SupportsAllAttributes("Given", "Given", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes: When")]
        public virtual void SupportsAllAttributes_When()
        {
            this.SupportsAllAttributes("When", "When", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes: Then")]
        public virtual void SupportsAllAttributes_Then()
        {
            this.SupportsAllAttributes("Then", "Then", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes: StepDefinition")]
        public virtual void SupportsAllAttributes_StepDefinition()
        {
            this.SupportsAllAttributes("StepDefinition", "Given", ((string[])(null)));
#line hidden
        }
        
        public virtual void PascalCaseMethods(string @case, string method, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pascal case methods", exampleTags);
#line 107
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 108
 testRunner.Given("a scenario \'Simple Scenario\' as", "When I do something really important", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 112
 testRunner.And("the following step definitions", string.Format("[When]\r\npublic void {0}(string howMuch)\r\n{{}}", method), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.Then(string.Format("the binding method \'{0}\' is executed", method), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pascal case methods: embedded param")]
        public virtual void PascalCaseMethods_EmbeddedParam()
        {
            this.PascalCaseMethods("embedded param", "WhenIDoSomethingHOWMUCHImportant", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pascal case methods: param with underscore")]
        public virtual void PascalCaseMethods_ParamWithUnderscore()
        {
            this.PascalCaseMethods("param with underscore", "WhenIDoSomething_HOWMUCH_Important", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pascal case methods: mixed underscores")]
        public virtual void PascalCaseMethods_MixedUnderscores()
        {
            this.PascalCaseMethods("mixed underscores", "WhenI_Do_SomethingHOWMUCHImportant", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Underscore in parameter name")]
        public virtual void UnderscoreInParameterName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Underscore in parameter name", ((string[])(null)));
#line 127
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 128
 testRunner.Given("a scenario \'Simple Scenario\' as", "When Joe does something", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 132
 testRunner.And("the following step definitions", "[When]\r\npublic void When_W_H_O_does_something(string w_h_o)\r\n{\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.Then("the binding method \'When_W_H_O_does_something\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void FMethodNameCanBeUsedAsARegex(string @case, string method, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "fsharp"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("F# method name can be used as a regex", @__tags);
#line 143
this.ScenarioSetup(scenarioInfo);
#line 144
 testRunner.Given("there is an external F# class library project \'ExternalSteps_FSharp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 145
 testRunner.And("the following step definition in the external library", string.Format("let [<When>] {0} = ()", method), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("there is a SpecFlow project with a reference to the external library", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 150
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something really important", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
 testRunner.And("the specflow configuration is", "<specFlow>\r\n<stepAssemblies>\r\n<stepAssembly assembly=\"ExternalSteps_FSharp\" />\r\n<" +
                    "/stepAssemblies>\r\n</specFlow>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.Then("all tests should pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("F# method name can be used as a regex: simple")]
        [NUnit.Framework.CategoryAttribute("fsharp")]
        public virtual void FMethodNameCanBeUsedAsARegex_Simple()
        {
            this.FMethodNameCanBeUsedAsARegex("simple", "``I do something really important``()", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("F# method name can be used as a regex: basic regex ops")]
        [NUnit.Framework.CategoryAttribute("fsharp")]
        public virtual void FMethodNameCanBeUsedAsARegex_BasicRegexOps()
        {
            this.FMethodNameCanBeUsedAsARegex("basic regex ops", "``I do something .* important``()", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("F# method name can be used as a regex: parameter")]
        [NUnit.Framework.CategoryAttribute("fsharp")]
        public virtual void FMethodNameCanBeUsedAsARegex_Parameter()
        {
            this.FMethodNameCanBeUsedAsARegex("parameter", "``I do something (.*) important``(howMuch: string)", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("F# method name can be used as a regex: non-regex method name")]
        [NUnit.Framework.CategoryAttribute("fsharp")]
        public virtual void FMethodNameCanBeUsedAsARegex_Non_RegexMethodName()
        {
            this.FMethodNameCanBeUsedAsARegex("non-regex method name", "When_I_do_something_really_important()", ((string[])(null)));
#line hidden
        }
        
        public virtual void Non_EnglishKeywords(string @case, string keyword, string methodPrefix, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Non-English keywords", exampleTags);
#line 172
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 175
 testRunner.Given("there is a feature file in the project as", string.Format("\tFunktionalität: German\r\n\tSzenario: Zwei Zahlen hinzufügen\r\n\t\t{0} ich Knopf drück" +
                        "e", keyword), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 181
 testRunner.And("the following step definitions", string.Format("[Given]\r\npublic void {0}ich_Knopf_drücke()\r\n{{}}", methodPrefix), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 187
 testRunner.And("the specflow configuration is", "<specFlow>\r\n<!-- the localized prefixes are detected if the \r\nfeature language or" +
                    " the binding culture is set in the config -->\r\n<language feature=\"de-DE\" /> \r\n<!" +
                    "--<bindingCulture name=\"de-DE\" />-->\r\n</specFlow>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 197
 testRunner.Then(string.Format("the binding method \'{0}ich_Knopf_drücke\' is executed", methodPrefix), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Non-English keywords: No prefix")]
        public virtual void Non_EnglishKeywords_NoPrefix()
        {
            this.Non_EnglishKeywords("No prefix", "Angenommen", "", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Non-English keywords: English prefix")]
        public virtual void Non_EnglishKeywords_EnglishPrefix()
        {
            this.Non_EnglishKeywords("English prefix", "Angenommen", "Given_", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Non-English keywords: Single word licalized prefix")]
        public virtual void Non_EnglishKeywords_SingleWordLicalizedPrefix()
        {
            this.Non_EnglishKeywords("Single word licalized prefix", "Angenommen", "Angenommen_", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Non-English keywords: Multiple word licalized prefix")]
        public virtual void Non_EnglishKeywords_MultipleWordLicalizedPrefix()
        {
            this.Non_EnglishKeywords("Multiple word licalized prefix", "Gegeben sei", "Gegeben_sei_", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Non-English keywords: Mixed keyword variants")]
        public virtual void Non_EnglishKeywords_MixedKeywordVariants()
        {
            this.Non_EnglishKeywords("Mixed keyword variants", "Gegeben sei", "Angenommen_", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters with negative values")]
        public virtual void StepsWithParametersWithNegativeValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with parameters with negative values", ((string[])(null)));
#line 208
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 209
 testRunner.Given("a scenario \'Simple Scenario\' as", "Given MinimumAmount is -0.01", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 213
 testRunner.And("the following step definitions", "[Given]\r\npublic void Given_MinimumAmount_is_P0(decimal p0)\r\n{\r\n    if (p0 != Conv" +
                    "ert.ToDecimal(-0.01)) throw new Exception(\"the parameter passed was not negative" +
                    "\");\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 221
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 222
 testRunner.Then("the binding method \'Given_MinimumAmount_is_P0\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with currency amounts")]
        public virtual void StepsWithCurrencyAmounts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with currency amounts", ((string[])(null)));
#line 224
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 225
 testRunner.Given("a scenario \'Simple Scenario\' as", "Given I pay £0.01", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 229
 testRunner.And("the following step definitions", "[Given]\r\npublic void Given_I_pay_P0(decimal p0)\r\n{\r\n    if (p0 != Convert.ToDecim" +
                    "al(0.01)) throw new Exception(\"the parameter passed was not a number\");\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 237
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 238
 testRunner.Then("the binding method \'Given_I_pay_P0\' is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
