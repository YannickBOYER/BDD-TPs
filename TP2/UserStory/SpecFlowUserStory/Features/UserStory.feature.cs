﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowUserStory.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CalculatorFeature : object, Xunit.IClassFixture<CalculatorFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UserStory.feature"
#line hidden
        
        public CalculatorFeature(CalculatorFeature.FixtureData fixtureData, SpecFlowUserStory_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Calculator", @"![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowUserStory/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Choisir le candidat gagnant au premier tour")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculator")]
        [Xunit.TraitAttribute("Description", "Choisir le candidat gagnant au premier tour")]
        [Xunit.TraitAttribute("Category", "mytag")]
        public virtual void ChoisirLeCandidatGagnantAuPremierTour()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Choisir le candidat gagnant au premier tour", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 9
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
#line 10
 testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table1.AddRow(new string[] {
                            "A",
                            "30"});
                table1.AddRow(new string[] {
                            "B",
                            "15"});
                table1.AddRow(new string[] {
                            "C",
                            "55"});
#line 11
 testRunner.And("resultat du tour", ((string)(null)), table1, "And ");
#line hidden
#line 16
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("le candidat gagnant doit être \"C\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Choisir le candidat gagnant au deuxième tour")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculator")]
        [Xunit.TraitAttribute("Description", "Choisir le candidat gagnant au deuxième tour")]
        public virtual void ChoisirLeCandidatGagnantAuDeuxiemeTour()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Choisir le candidat gagnant au deuxième tour", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 19
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
#line 20
 testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table2.AddRow(new string[] {
                            "A",
                            "25"});
                table2.AddRow(new string[] {
                            "B",
                            "35"});
                table2.AddRow(new string[] {
                            "C",
                            "40"});
#line 21
 testRunner.And("resultat du tour", ((string)(null)), table2, "And ");
#line hidden
#line 26
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table3.AddRow(new string[] {
                            "A",
                            "60"});
                table3.AddRow(new string[] {
                            "C",
                            "40"});
#line 28
 testRunner.And("resultat du tour", ((string)(null)), table3, "And ");
#line hidden
#line 32
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("le candidat gagnant doit être \"A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Décider qu\'il y a égalité au second tour")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculator")]
        [Xunit.TraitAttribute("Description", "Décider qu\'il y a égalité au second tour")]
        public virtual void DeciderQuilYAEgaliteAuSecondTour()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Décider qu\'il y a égalité au second tour", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 35
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
#line 36
 testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table4.AddRow(new string[] {
                            "A",
                            "25"});
                table4.AddRow(new string[] {
                            "B",
                            "35"});
                table4.AddRow(new string[] {
                            "C",
                            "40"});
#line 37
 testRunner.And("resultat du tour", ((string)(null)), table4, "And ");
#line hidden
#line 42
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table5.AddRow(new string[] {
                            "A",
                            "50"});
                table5.AddRow(new string[] {
                            "C",
                            "50"});
#line 44
 testRunner.And("resultat du tour", ((string)(null)), table5, "And ");
#line hidden
#line 48
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("il doit y avoir une égalité entre \"A\" et \"C\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Égaliter entre le 2ème et le 3ème candidat au premier tour")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculator")]
        [Xunit.TraitAttribute("Description", "Égaliter entre le 2ème et le 3ème candidat au premier tour")]
        public virtual void EgaliterEntreLe2EmeEtLe3EmeCandidatAuPremierTour()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Égaliter entre le 2ème et le 3ème candidat au premier tour", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 51
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
#line 52
 testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table6.AddRow(new string[] {
                            "A",
                            "30"});
                table6.AddRow(new string[] {
                            "B",
                            "30"});
                table6.AddRow(new string[] {
                            "C",
                            "40"});
#line 53
 testRunner.And("resultat du tour", ((string)(null)), table6, "And ");
#line hidden
#line 58
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
    testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table7.AddRow(new string[] {
                            "A",
                            "60"});
                table7.AddRow(new string[] {
                            "C",
                            "40"});
#line 60
 testRunner.And("resultat du tour", ((string)(null)), table7, "And ");
#line hidden
#line 64
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.Then("le candidat gagnant doit être \"A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Gestion des votes blancs")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculator")]
        [Xunit.TraitAttribute("Description", "Gestion des votes blancs")]
        public virtual void GestionDesVotesBlancs()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Gestion des votes blancs", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 67
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
#line 68
 testRunner.Given("le nombre de voix exprimées est 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de voix"});
                table8.AddRow(new string[] {
                            "A",
                            "40"});
                table8.AddRow(new string[] {
                            "B",
                            "60"});
                table8.AddRow(new string[] {
                            "Blanc",
                            "100"});
#line 69
 testRunner.And("resultat du tour", ((string)(null)), table8, "And ");
#line hidden
#line 74
 testRunner.When("le tour est terminé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then("le candidat gagnant doit être \"B\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CalculatorFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CalculatorFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
