using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string url = "http://localhost:52393/Clients/Create";
            string url = "http://localhost:52393";

            ChromeDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            CreateClient(driver);

            CreateEmployee(driver);

            CreateService(driver);

            CreateJob(driver);
        }

        public void CreateClient(ChromeDriver driver)
        {
            //Client Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Clients")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Marge Simpson");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        public void CreateEmployee(ChromeDriver driver)
        {
            //Employee Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("DOE")).SendKeys("2021-01-01");
            driver.FindElement(By.Id("Name")).SendKeys("Lard Simpson");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        public void CreateService(ChromeDriver driver)
        {
            //Employee Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Services")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("ServiceName")).SendKeys("Dog Walking");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }
        public void CreateJob(ChromeDriver driver)
        {
            //Employee Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Jobs")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            SelectElement oSelect1 = new SelectElement(driver.FindElement(By.Id("ClientID")));
            oSelect1.SelectByText("Marge Simpson");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("ServiceID")));
            oSelect.SelectByText("Dog Walking");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

    }
}
