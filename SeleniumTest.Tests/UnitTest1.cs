using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SeleniumTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreate()
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
            String client = "Marge Simpson";
            //Client Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Clients")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys(client);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            String expectedURL = "http://localhost:52393/Clients";
            Boolean verifyRedirect = driver.Url.Equals(expectedURL);
            Assert.IsTrue(verifyRedirect);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Boolean verifyClientIsPresent = false;
            IList<IWebElement> allElement = driver.FindElements(By.TagName("td"));
            foreach (IWebElement element in allElement)
            {
                string cellText = element.Text;
                if (cellText == client)
                {
                    verifyClientIsPresent = true;
                    break;
                }
            }
            Assert.IsTrue(verifyClientIsPresent);
        }

        public void CreateEmployee(ChromeDriver driver)
        {
            String employee = "Lard Simpson";
            //Employee Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("DOE")).SendKeys("2021-01-01");
            driver.FindElement(By.Id("Name")).SendKeys(employee);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();

            String expectedURL = "http://localhost:52393/Employees";
            Boolean verifyRedirect = driver.Url.Equals(expectedURL);
            Assert.IsTrue(verifyRedirect);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Boolean verifyEmployeeIsPresent = false;
            IList<IWebElement> allElement = driver.FindElements(By.TagName("td"));
            foreach (IWebElement element in allElement)
            {
                string cellText = element.Text;
                if (cellText == employee)
                {
                    verifyEmployeeIsPresent = true;
                }
            }
            Assert.IsTrue(verifyEmployeeIsPresent);
        }

        public void CreateService(ChromeDriver driver)
        {
            String service = "Dog Walking";
            //Employee Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Services")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("ServiceName")).SendKeys(service);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();

            String expectedURL = "http://localhost:52393/Services";
            Boolean verifyRedirect = driver.Url.Equals(expectedURL);
            Assert.IsTrue(verifyRedirect);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Boolean verifyServiceIsPresent = false;
            IList<IWebElement> allElement = driver.FindElements(By.TagName("td"));
            foreach (IWebElement element in allElement)
            {
                string cellText = element.Text;
                if (cellText == service)
                {
                    verifyServiceIsPresent = true;
                }
            }
            Assert.IsTrue(verifyServiceIsPresent);
        }
        public void CreateJob(ChromeDriver driver)
        {
            String client = "Marge Simpson";
            String service = "Dog Walking";
            //Employee Create
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Jobs")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            SelectElement oSelect1 = new SelectElement(driver.FindElement(By.Id("ClientID")));
            oSelect1.SelectByText(client);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("ServiceID")));
            oSelect.SelectByText(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();


            String expectedURL = "http://localhost:52393/Jobs";
            Boolean verifyRedirect = driver.Url.Equals(expectedURL);
            Assert.IsTrue(verifyRedirect);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Boolean verifyJobIsPresent = false;
            List<string> jobs = new List<string>();
            int counter = 0;
            IList<IWebElement> allElement = driver.FindElements(By.TagName("td"));
            foreach (IWebElement element in allElement)
            {
                if (counter == 2)
                {
                    if (jobs[0] == client && jobs[1] == service)
                    {
                        verifyJobIsPresent = true;
                        break;
                    } 
                }
                if (counter < 2)
                {
                    jobs.Add(element.Text);
                    counter++;
                } else
                {
                    jobs.Clear();
                    counter = 0;
                }
            }
            
            Assert.IsTrue(verifyJobIsPresent);
        }

    }
}
