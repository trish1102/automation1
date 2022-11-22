//open browser
using automation1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

IWebDriver driver = new ChromeDriver();

//import loginpage here
Loginpage loginpageobj = new Loginpage();
loginpageobj.loginaction(driver);
//import Homepage here
Homepage homepageobj = new Homepage();
homepageobj.gotoTMpage(driver);
//import TMpage here
TMpage tmpageobj = new TMpage();
tmpageobj.createTM(driver);
tmpageobj.editTM(driver);
tmpageobj.deleteTM(driver);







