using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTests.Pages
{
    public class HomePage : Form
    {
        private ILink HereLink => ElementFactory.GetLink(By.XPath("//*[contains(@class,'start__link')]"), "Here");

        public HomePage() : base(By.XPath("//button[contains(@class,'start__button')]"), "Home Page")
        { }

        public void ClickHereLink() => HereLink.Click();
    }
}
