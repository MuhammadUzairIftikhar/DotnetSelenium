using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Sudo Code for setting up Selenium
            // 1. Create a new instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            // 2. Navigate to the URL
            driver.Navigate().GoToUrl("https://www.google.com/");

            // 2a. Maximize the Browser Window
            driver.Manage().Window.Maximize();
            // 3. Find the Element 
            IWebElement webElement = driver.FindElement(By.Name("q"));
            // 4. Type in the Element 
            webElement.SendKeys("Selenium");
            // 5. Click on the Element 
            webElement.SendKeys(Keys.Return);
        }

        [Test]
        public void EAWebsiteTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            // This is using Custom Method to Speed up the task
            SeleniumCustomMethod.click(driver, By.Id("loginLink"));

            // Previous Method 
            // IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
            // txtUserName.SendKeys("admin");

            // This is using Custom Method to Speed up the task
            SeleniumCustomMethod.EnterText(driver, By.Name("UserName"), "admin");

            // Previous Method
            // IWebElement txtPassword = driver.FindElement(By.Name("Password"));
            // txtPassword.SendKeys("password");

            // This is the Sped Up Method
            SeleniumCustomMethod.EnterText(driver, By.Name("Password"), "password");

            IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn"));
            btnLogin.Submit();

            
            

        }
    }
}