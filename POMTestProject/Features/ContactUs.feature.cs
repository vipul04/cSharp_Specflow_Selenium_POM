﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace POMTestProject.Features
{
    using TechTalk.SpecFlow;
    using Autofac;
    using Autofac.Configuration;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Contact Us Page")]
    public partial class ContactUsPageFeature
    {
        
        private OpenQA.Selenium.IWebDriver driver;
        
        private IContainer container;
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContactUs.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            this.container = builder.Build();
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Contact Us Page", "As an end user\r\nI want a contact us page\r\nSo that I can find out more about QAWor" +
                    "ks exciting services!!", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            try { System.Threading.Thread.Sleep(50); this.driver.Quit(); } catch (System.Exception) {}
            this.driver = null;
            ScenarioContext.Current.Remove("Driver");
            ScenarioContext.Current.Remove("Container");
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            if(this.driver != null)
                ScenarioContext.Current.Add("Driver", this.driver);
            if(this.container != null)
                ScenarioContext.Current.Add("Container", this.container);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        private void InitializeSelenium(string browser)
        {
            this.driver = this.container.ResolveNamed<OpenQA.Selenium.IWebDriver>(browser);
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Submission")]
        [NUnit.Framework.TestCaseAttribute("Chrome", "j.Bloggs", "j.Bloggs@qaworks.com", "test automation", "please contact me I want to find out more", null, Category="Chrome", TestName="ValidSubmission on Chrome with: \"j.Bloggs\" ,\"j.Bloggs@qaworks.com\" ,\"test automat" +
            "ion\" ,\"please contact me I want to find out more\"")]
        public virtual void ValidSubmission(string browser, string name, string email, string subject, string message, string[] exampleTags)
        {
            InitializeSelenium(browser);
            string[] @__tags = new string[] {
                    "Browser:Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Submission", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I am on the QAWorks Site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I navigate to the Contact Us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Subject",
                        "Message"});
            table1.AddRow(new string[] {
                        string.Format("{0}", name),
                        string.Format("{0}", email),
                        string.Format("{0}", subject),
                        string.Format("{0}", message)});
#line 10
 testRunner.And("enter the following information", ((string)(null)), table1, "And ");
#line 13
    testRunner.Then("I should see the \"×\\r\\nTHANK YOU FOR YOUR MESSAGE.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
