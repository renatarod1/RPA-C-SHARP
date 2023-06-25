using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBot {
    public class AutomationWeb {
        public IWebDriver driver;

        public AutomationWeb() {
            driver = new ChromeDriver();
        }

        public string TestWeb() {
            driver.Navigate().GoToUrl("https://www.google.com.br");

            driver.FindElement(By.Name("q")).SendKeys("Site Concatenar");
            
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();
            
            var text = driver.FindElement(By.XPath("//*[@id=\'rso\']/div[1]/div/div/div[2]/div/span")).Text;

            return text;
        }
    }
}
