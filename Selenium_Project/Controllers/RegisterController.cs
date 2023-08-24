
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Project.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StartAutomation()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://example.com/register");

            IWebElement usernameInput = driver.FindElement(By.Id("username"));
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));

            usernameInput.SendKeys("burakkertn");
            emailInput.SendKeys("burakkertnn@gmail.com");
            passwordInput.SendKeys("123456Aa*");

            registerButton.Click();

            // Sayfanın yüklenmesini beklemek için bekleyin (WebDriverWait kullanmanız önerilir)

            driver.Quit();

            return View("Index");
        }
    }
}
