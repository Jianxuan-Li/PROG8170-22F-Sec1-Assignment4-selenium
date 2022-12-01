﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Assignment4
{
    [TestFixture]
    public class Assignment4Test
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }


        [Test]
        public void age25Experience3Accident0()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            js.ExecuteScript("window.scrollTo(0,168)");
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$2500"));
            }
        }
        [Test]
        public void age25Experience3Accident4()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("4");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
            }
        }
        [Test]
        public void age27Experience3Accident0()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$2500"));
            }
        }
        [Test]
        public void age28Experience3Accident0()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("28");
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            js.ExecuteScript("window.scrollTo(0,168)");
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$2500"));
            }
        }
        [Test]
        public void age35Experience10Accident2()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("10");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$1350"));
            }
        }
        [Test]
        public void age35Experience17Accident1()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("17");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$1350"));
            }
        }
        [Test]
        public void age37Experience8AccidentNull()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("37");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("8");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("accidents-error"));
            Assert.True(elements.Count > 0);
        }
        [Test]
        public void age45ExperienceNullAccident0()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("45");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("experience-error"));
            Assert.True(elements.Count > 0);
        }
        [Test]
        public void ageNullExperience5Accident0()
        {
            driver.Navigate().GoToUrl("http://localhost/getQuote.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jianxuan");
            driver.FindElement(By.Id("lastName")).SendKeys("Li");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2K 0H2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("5");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("age-error"));
            Assert.True(elements.Count > 0);
        }


    }
}
