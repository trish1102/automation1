using System;
using TechTalk.SpecFlow;

namespace automation1.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialFeatureStepDefinitions :ComonDriver
    {
        //import loginpage here
        Loginpage loginpageobj = new Loginpage();
        Homepage homepageobj = new Homepage();
        TMpage tmpageobj = new TMpage();
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
            
            loginpageobj.loginaction(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            
            homepageobj.gotoTMpage(driver);
            
        }

        [When(@"I create a new Time and Material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            
            tmpageobj.createTM(driver);

        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
          
            string newcode = tmpageobj.GetCode(driver);
            Assert.That(newcode == "123", "Actual code and expected code do not match.");
        }
        
           
        [When(@"I update '([^']*)','([^']*)','([^']*)' in last created record")]
        public void WhenIUpdateInLastCreatedRecord(string Description, string Code, string Price)
        {
            
            tmpageobj.editTM(driver, Description,Code,Price);

        }
        [Then(@"The record should have updated '([^']*)','([^']*)','([^']*)' successfully")]
        public void ThenTheRecordShouldHaveUpdatedSuccessfully(string Description, string Code, string Price)
        {
                string UpdatedDescription = tmpageobj.geteditedDescription(driver);
                Assert.That(UpdatedDescription == Description, "update description failed");
                string UpdatedCode = tmpageobj.geteditedCode(driver);
                Assert.That(UpdatedCode == Code, "update code failed");
                string UpdatedPrice = tmpageobj.geteditPrice(driver);
                Assert.That(UpdatedPrice == Price, "update code failed");


        }






    }
}
