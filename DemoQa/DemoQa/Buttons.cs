using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQa
{
    public class Buttons
    {
        public void Button(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement button = wait.Until(d => d.FindElement(By.XPath("//li[@id='item-4']//span[text()='Buttons']")));
            button.Click();
            Actions actions = new Actions(driver);
            IWebElement DoubleClick = wait.Until(d => d.FindElement(By.XPath("//button[@id='doubleClickBtn']")));
            Actions actions1 = actions.DoubleClick();
            actions1.Perform();
            actions1.Perform();




        }
    }
}
