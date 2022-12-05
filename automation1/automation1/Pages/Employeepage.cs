

namespace automation1.Pages
{
    public class Employeepage: ComonDriver
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //click on create button
            IWebElement createEmployeeButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createEmployeeButton.Click();
            // enter value in Name Textbox
            IWebElement nameTextbox = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
            nameTextbox.SendKeys("Kyra");
            //enter value in Username Textbox
            IWebElement usernameTextbox = driver.FindElement(By.XPath("//*[@id=\"Username\"]"));
            usernameTextbox.SendKeys("Kyra");
            //enter value in Contact Textbox
            IWebElement contactTextbox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            contactTextbox.SendKeys("345566663");
            //enter value in password Textbox
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            passwordTextbox.SendKeys("Trisha105");
            //enter value in ReTypepassword Textbox
            IWebElement retypepasswordTextbox = driver.FindElement(By.XPath("//*[@id=\"RetypePassword\"]"));
            retypepasswordTextbox.SendKeys("Trisha105");
            //enter value in Vehicle Textbox
            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("car");
            //enter value in Groups Textbox
            IWebElement groupdropbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
             groupdropbox.Click();
           // groupdropbox.SendKeys("nztest");
             //click on save button
            IWebElement saveemployeeButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveemployeeButton.Click();
            Thread.Sleep(3000);
            IWebElement backtolistButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolistButton.Click();
            Thread.Sleep(500);
            //goto lastpage
            IWebElement gotoemployeelastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoemployeelastpage.Click();
            //check if Employee record create successfully
            IWebElement newnameTextbox = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newnameTextbox.Text == "Kyra");

        }
        public void EditEmployee(IWebDriver driver)

        {
            // click on last button
            IWebElement lastbutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastbutton.Click();
            Thread.Sleep(500);
            //click on edit button
            IWebElement editemployeeButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editemployeeButton.Click();
            //enter new value in name textbox
            IWebElement newname = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
            newname.Clear();
            newname.SendKeys("Trisha");
            //click on save button
            IWebElement save = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            save.Click();
            //click on back to list button
            IWebElement backtolist = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolist.Click();
            // click on last button
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastpage.Click();
            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(name.Text=="Trisha","edit did not work");


        }
        public void DeleteEmployee(IWebDriver driver)
        {
            // click on last button
            IWebElement lastbutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastbutton.Click();
            Thread.Sleep(500);
            IWebElement deleteemployeeButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteemployeeButton.Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
