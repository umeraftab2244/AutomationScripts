using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DemoQa
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://demoqa.com/");
            Thread.Sleep(4000);
            IWebElement element = wait.Until(d => d.FindElement(By.XPath("//div[@class='category-cards']/div[1]")));
            element.Click();
          // IWebElement TextBox = wait.Until(d => d.FindElement(By.XPath("//li[@id='item-0' and @class='btn btn-light ' and .//span[@class='text' and normalize-space()='Text Box']]")));
          //  TextBox.Click();
          // Elements elements = new Elements();
          // elements.fields(driver);
          // TextBox textBoxx = new TextBox();
          // textBoxx.text(driver);
          //  RadioButton radioButton = new RadioButton();
          //  radioButton.RadioButton1(driver);
          //  WebTables webTables = new WebTables();
          //  webTables.WebTables1(driver);
            Buttons buttons = new Buttons();
            buttons.Button(driver);
            
            








        }
        
    }

}