

namespace automation1.Utilities
{
    public class ComonDriver
    {
         
        public  IWebDriver driver;
        [OneTimeSetUp]

        public void loginSteps()
        {
            driver = new ChromeDriver();
            //import loginpage here
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.loginaction(driver);

        }
     [OneTimeTearDown]
       public void CloseTestRun()
        {
        driver.Quit();
        }

    }

}

