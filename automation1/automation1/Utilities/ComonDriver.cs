using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation1.Utilities
{
    public class ComonDriver
    {
         
        public static IWebDriver driver;
        [SetUp]

        public void loginSteps()
        {
            driver = new ChromeDriver();
            //import loginpage here
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.loginaction(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }

}

