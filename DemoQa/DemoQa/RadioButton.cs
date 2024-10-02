using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQa
{
    public class RadioButton
    {
        public void RadioButton1(IWebDriver driver) 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement radiobutton = wait.Until(d => d.FindElement(By.XPath("//span[text()='Radio Button']")));
            radiobutton.Click();
            IWebElement Yes = wait.Until(d => d.FindElement(By.XPath("//label[@for='yesRadio']")));
            Yes.Click();
        }
        
    }
    
}
