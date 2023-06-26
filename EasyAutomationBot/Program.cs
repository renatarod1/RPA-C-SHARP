using EasyAutomationFramework;
using OpenQA.Selenium;

namespace EasyAutomationBot {
    internal class Program {
        static void Main(string[] args) {
            var web = new Web();

            web.StartBrowser();

            web.Navigate("https://www.google.com.br");

            web.AssignValue(TypeElement.Name, "q", "Site Concatenar").element.SendKeys(Keys.Enter);

            web.WaitForLoad();

            web.Click(TypeElement.Xpath, "//*[@id=\'rso\']/div[1]/div/div/div[1]/div/a/h3");

            web.Click(TypeElement.Xpath, "//*[@id=\'rt-mainbody\']/div/section/div[1]/article[2]/div/p[3]/a");
            web.WaitForLoad();
        }
    }
}