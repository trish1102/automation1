using System;
using TechTalk.SpecFlow;

namespace automation1.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialFeatureStepDefinitions :ComonDriver
    {
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
            //import loginpage here
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.loginaction(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            Homepage homepageobj = new Homepage();
            homepageobj.gotoTMpage(driver);
            
        }

        [When(@"I create a new Time and Material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            TMpage tmpageobj = new TMpage();
            tmpageobj.createTM(driver);

        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMpage tmpageobj = new TMpage();
            string newcode = tmpageobj.GetCode(driver);
            Assert.That(newcode == "123", "Actual code and expected code do not match.");
        }
        [When(@"I update '([^']*)' in last created record")]
        public void WhenIUpdateInLastCreatedRecord(string Description)
        {
            TMpage tmpageobj = new TMpage();
             tmpageobj.editTM(driver,Description);

        }
        [Then(@"The record should have updated '([^']*)' successfully")]
        public void ThenTheRecordShouldHaveUpdatedSuccessfully(string Description)
        {
            TMpage tmpageobj = new TMpage();
            string UpdatedDescription = tmpageobj.geteditedvalue(driver);
            Assert.That(UpdatedDescription == Description, "update description failed");
        }





    }
}
