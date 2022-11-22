﻿using automation1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Thread.Sleep(1000);
            //click on last page button
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(3000);
            //confirm its entered successfully
            IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newcode.Text == "123")
            {
                Console.WriteLine("material record created successfully");
            }
            else
            {
                Console.WriteLine("record hasn't created successfully");
            }
        }
        public void editTM(IWebDriver driver)
        {

            //click on edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            ////*[@id="tmsGrid"]/div[3]/table/tbody/tr/td[5]/a[1]
            editButton.Click();
            Thread.Sleep(500);
            //edit values
            IWebElement codeTextbox1 = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTextbox1.Clear();
            codeTextbox1.SendKeys("567");

            //save values
            IWebElement savevalue = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            savevalue.Click();
            Thread.Sleep(3000);
            IWebElement pagelast = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            pagelast.Click();
            //check if its work
            IWebElement editcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editcode.Text == "567")
            {
                Console.WriteLine("record edited successfully");
            }
            else
            {
                Console.WriteLine("record editing failed");
            }
        }
        public void deleteTM(IWebDriver driver)
        {
            //delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[last()]/a[last()]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}