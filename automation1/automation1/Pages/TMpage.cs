﻿

using System.Security.Cryptography.X509Certificates;

namespace automation1.Pages
{
    public class TMpage
    {
        public void createTM(IWebDriver driver)
        {
            //create new record
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewButton.Click();
            // Thread.Sleep(500);
            Wait.WaitForElementTobeExist(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 6);
            //scrolldown and click value in typecode 
            IWebElement typecodeScrolldown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeScrolldown.Click();
            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));

            timeoption.Click();
            //enter value in code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("123");
            //enter value in description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("123");
            //enter value in price per unit(only number)
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span"));
            overlappingTag.Click();
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
            priceTextbox.SendKeys("123");
            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);
           // Wait.WaitForElementToBeClickable(driver,"XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",10);
            //click on last page button
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(3000);
            //Wait.WaitForElementTobeExist(driver,"XPath","//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]",10);
            //confirm its entered successfully
            
            
            //  if (newcode.Text == "123")
            // {
            //Console.WriteLine("material record created successfully");
            //Assert.Pass("test passed successfully");
            //}
            //else
            //{
             //   Console.WriteLine("record hasn't created successfully");
            //}
        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement actualcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualcode.Text;
        }

        public void editTM(IWebDriver driver,string Description,string Code,string Price)
        {
            Thread.Sleep(3000);
            IWebElement pagelast2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            pagelast2.Click();
            //click on edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(500);
            //edit values
            IWebElement codeTextbox1 = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTextbox1.Clear();
            codeTextbox1.SendKeys(Code);
            IWebElement discription1 = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            discription1.Clear();
            discription1.SendKeys(Description);
            Thread.Sleep(500);
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span"));
            
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
            overlappingTag.Click();
           
            priceTextbox.Clear();
            overlappingTag.Click();

            priceTextbox.SendKeys(Price);
            // IWebElement pricetextbox1 = driver.FindElement(By.Id("Price"));
            //pricetextbox1.Clear();
            // pricetextbox1.SendKeys(Price);
            //save values
            IWebElement savevalue = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            savevalue.Click();
            Thread.Sleep(3000);
           // Wait.WaitForElementToBeClickable(driver,"XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",10);
            IWebElement pagelast1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            pagelast1.Click();
            //check if its work
            Wait.WaitForElementTobeExist(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 10);
           // IWebElement editcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Assert.That(editcode.Text == "567" , "Actual code and expected code do not match.");
           // if (editcode.Text == "567")
            //{
              //  Console.WriteLine("record edited successfully");
           // }
           // else
           // {
           //     Console.WriteLine("record editing failed");
            //}
        }
        public string geteditedDescription(IWebDriver driver)
        {
            IWebElement editDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editDescription.Text;
        }
        public string geteditedCode(IWebDriver driver)
        {
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return editCode.Text;
        }
        public string geteditPrice(IWebDriver driver)
        {
            IWebElement editPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return editPrice.Text;
        }

        public void deleteTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement pagelast = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            pagelast.Click();
            //delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[last()]/a[last()]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
