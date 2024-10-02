using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQa
{
    public partial class WebTables
    {
        public void WebTables1(IWebDriver driver)
        {
            ReadDataFromExcel(2);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement WebTables = wait.Until(d => d.FindElement(By.XPath("//li[@id='item-3' and @class='btn btn-light ' and .//span[@class='text' and normalize-space()='Web Tables']]")));
            WebTables.Click();
            IWebElement Add = wait.Until(d => d.FindElement(By.XPath("//button[@id='addNewRecordButton']")));
            Add.Click();
            IWebElement FirstName = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='First Name']")));
            FirstName.SendKeys(FirstNameData);
            IWebElement LastName = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Last Name']")));
            LastName.SendKeys(LastNameData);
            IWebElement Email = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='name@example.com']")));
            Email.SendKeys(EmailData);
            IWebElement Age = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Age']")));
            Age.SendKeys(AgeData);
            IWebElement Salary = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Salary']")));
            Salary.SendKeys(SalaryData);
            IWebElement Department = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Department']")));
            Department.SendKeys(DepartmentData);
            IWebElement Submit = wait.Until(d => d.FindElement(By.XPath("//button[@id='submit']")));
            Submit.Click();
            IWebElement Search = wait.Until(d => d.FindElement(By.XPath("//input[@id='searchBox']")));
            Search.SendKeys("M.Umar");
            IWebElement Enter = wait.Until(d => d.FindElement(By.XPath("//span[@id='basic-addon2']")));
            Enter.Click();





        }
    }
}
