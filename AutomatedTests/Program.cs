using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomatedTests
{
    public class AutomatedTestForRegisterForm
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");

            IWebElement registerForm = driver.FindElement(By.ClassName("registerForm"));
            registerForm.Click();

            IWebElement firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Vyara");

            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Marinova");

            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("emailExample@gmail.com");

            IWebElement emailConfirm = driver.FindElement(By.Id("email_confirm"));
            emailConfirm.SendKeys("emailExample@gmail.com");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("p@ssword123");

            IWebElement passwordConfirm = driver.FindElement(By.Id("password_confirm"));
            passwordConfirm.SendKeys("p@ssword123");

            IWebElement gender = driver.FindElement(By.Name("gender"));
            gender.Click();

            IWebElement registerButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            registerButton.Click();


        }
    }
}
