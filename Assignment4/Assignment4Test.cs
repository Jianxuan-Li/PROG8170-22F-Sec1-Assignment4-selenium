using System;
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

        #region Constants

        //private static readonly string url = "http://localhost/getQuote.html";
        private static readonly string url = "http://localhost:8888/prog8170a04/getQuote.html";
        private static readonly string noInsuranceTxt = "No Insurance for you!! Driver Age / Experience Not Correct";
        private static readonly string manyAccident = "No Insurance for you!!  Too many accidents - go take a course!";

        #endregion


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
        public void case1Age25Experience3Accident0()
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
        public void case2Age25Experience3Accident4()
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
                Assert.That(value, Is.EqualTo(manyAccident));
            }
        }
        [Test]
        public void case4Age27Experience3Accident0()
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
            driver.FindElement(By.Id("phone")).SendKeys("abcdefg");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("liujin834@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            var elements = driver.FindElements(By.Id("phone-error"));
            Assert.True(elements.Count > 0);
        }
        [Test]
        public void case5Age28Experience3Accident0()
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
            driver.FindElement(By.Id("email")).SendKeys("111222333");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("28");
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            js.ExecuteScript("window.scrollTo(0,168)");
            var elements = driver.FindElements(By.Id("email-error"));
            Assert.True(elements.Count > 0);
        }
        [Test]
        public void case3Age35Experience10Accident2()
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
        public void case6Age35Experience17Accident1()
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
            driver.FindElement(By.Id("postalCode")).SendKeys("UHGESDF");
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
            var elements = driver.FindElements(By.Id("postalCode-error"));
            Assert.True(elements.Count > 0);
        }
        [Test]
        public void case8Age37Experience8AccidentNull()
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
        public void case9Age45ExperienceNullAccident0()
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
        public void case7AgeNullExperience5Accident0()
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


        #region Custom Test Cases

        //Custom test cases

        //Test where age is same as experience i.e. no gap

        [Test]
        public void Age50Experience50NoInsurance_OutIncorrectExperience()
        {
            //Arrange
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);

            //Act
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Aayush");
            driver.FindElement(By.Id("lastName")).SendKeys("Subedi");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2k 3R6");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("aayush@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("50");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("50");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("5");

            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var errorText = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

            //Assert
            Assert.AreEqual(noInsuranceTxt, errorText);
        }


        //Test where Experience is more as age i.e. negative gap
        [Test]
        public void Age44Experience50_NoInsurance_OutIncorrectExperience()
        {
            //Arrange
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);

            //Act
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Aayush");
            driver.FindElement(By.Id("lastName")).SendKeys("Subedi");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2k 3R6");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("aayush@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("44");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("50");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("5");

            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var errorText = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

            //Assert
            Assert.AreEqual(noInsuranceTxt, errorText);
        }

        //Test where num of accident is 3 or more
        //Arrange
        [Test]
        public void Accidents4_NoInsurance_OutGoTakeCourse()
        {
            //Arrange
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);

            //Act
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Aayush");
            driver.FindElement(By.Id("lastName")).SendKeys("Subedi");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2k 3R6");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("aayush@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("44");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("18");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("5");

            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var errorText = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

            //Assert
            Assert.AreEqual(manyAccident, errorText);
        }


        //•	If the driver has no driving experience, apply a base rate of $4000 annually
        [Test]
        public void ZeroExperience_ValidInput_Out4000Annual()
        {
             //Arrange
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);
            //Act
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Aayush");
            driver.FindElement(By.Id("lastName")).SendKeys("Subedi");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2k 3R6");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("aayush@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("44");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("0");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");

            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

            //Assert
            Assert.AreEqual("$4000", value);
        }

        //•	. If a driver has 1 to 9 years of experience, apply a base rate of $2500 annually
        [Test]
        public void Age22_Exp2Years_ValidInput_Out1875Annual()
        {
            //Arrange
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);

            //Act
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Aayush");
            driver.FindElement(By.Id("lastName")).SendKeys("Subedi");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2k 3R6");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("aayush@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("22");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("4");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");

            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

            //Assert
            Assert.AreEqual("$2500", value);
        }

        //•	If a driver is 30 years old or older and have at least two years of driving experience, apply a rate reduction of 25% of the base rate.
        [Test]
        public void Age30_Exp2Years_ValidInput_Out1875Annual()
        {
            //Arrange

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Size = new System.Drawing.Size(1841, 1032);

            //Act
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Aayush");
            driver.FindElement(By.Id("lastName")).SendKeys("Subedi");
            driver.FindElement(By.Id("address")).SendKeys("111 University Ave");
            driver.FindElement(By.CssSelector(".col-md-6")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2k 3R6");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector(".col-md-8")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("aayush@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("30");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");

            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            var value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

            //Assert
            Assert.AreEqual("1875", value);
        }


        #endregion
    }
}
