using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQa
{
    public class TextBox
    {
        public void text(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement textbox = wait.Until(d => d.FindElement(By.XPath("//li[@id='item-1' and @class='btn btn-light ' and .//span[@class='text' and normalize-space()='Check Box']]")));
            textbox.Click();
            IWebElement Togle1 = wait.Until(d => d.FindElement(By.XPath("//button[@class='rct-collapse rct-collapse-btn']")));
            Togle1.Click();
            IWebElement Togle2 = wait.Until(d => d.FindElement(By.XPath("//label[@for='tree-node-desktop']/../button")));
            Togle2.Click();
            IWebElement commands = wait.Until(d => d.FindElement(By.XPath("//label[@for='tree-node-commands']/../span/../label")));
            commands.Click();
        }
    }
}
