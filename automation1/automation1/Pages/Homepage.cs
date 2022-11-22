using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation1.Pages
{
    public class Homepage
    {
        public void gotoTMpage(IWebDriver driver)
        {
            //click on administration scrolldown
            IWebElement administrationScrolldown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationScrolldown.Click();
            Thread.Sleep(500);
            //click time&materials
            IWebElement timematerials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            //
            timematerials.Click();
        }
    }
}
