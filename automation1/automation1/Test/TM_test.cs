using automation1.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;
using NUnit.Framework;
using automation1.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace automation1.Test
{
    [TestFixture]
    public class TM_test : ComonDriver
    {
        [SetUp]

        public void loginSteps()
        {
            driver = new ChromeDriver();
            //import loginpage here
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.loginaction(driver);
            //import Homepage here
            Homepage homepageobj = new Homepage();
            homepageobj.gotoTMpage(driver);
            //import TMpage here

        }
        [Test]
        public void CreateTM_Test()
        {
            TMpage tmpageobj = new TMpage();
            tmpageobj.createTM(driver);

        }
        [Test]
        public void EditTM_Test()
        {
            TMpage tmpageobj = new TMpage();
            tmpageobj.editTM(driver);
        }
        [Test]
        public void DeleteTM_Test()
        {
            TMpage tmpageobj = new TMpage();
            tmpageobj.deleteTM(driver);
        }
       [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

      




    }
}



