

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
        public void GoToEmployeePage(IWebDriver driver)
        {
            //click on administration
            IWebElement administrationScrolldown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationScrolldown.Click();
            Thread.Sleep(500);
            //open dropbox and select Employee
            IWebElement Employee = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employee.Click();
        }
    }
}
