using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;
using ClosedXML.Excel;

namespace DemoQa
{
    public partial class Elements
    {
        public void fields(IWebDriver driver)
        {
            ReadDataFromExcel(2);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement FullName = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Full Name']")));
            FullName.SendKeys(fullnameData);
            IWebElement Email = wait.Until(d => d.FindElement(By.XPath("//input[@id='userEmail']")));
            Email.SendKeys(emailData);
            IWebElement CurrentAddress = wait.Until(d => d.FindElement(By.XPath("//textarea[@placeholder='Current Address']")));
            CurrentAddress.SendKeys(currentaddressData);
            IWebElement PermanentAddress = wait.Until(d => d.FindElement(By.XPath("//textarea[@id='permanentAddress']")));
            PermanentAddress.SendKeys(PermanentaddressData);
            IWebElement Submit = wait.Until(d => d.FindElement(By.XPath("//button[@class='btn btn-primary']")));
            Submit.Click();
            Submit.Click();

        }
    }
}
