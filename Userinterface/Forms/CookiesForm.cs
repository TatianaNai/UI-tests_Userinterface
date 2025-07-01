using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTests.Forms
{
    public class CookiesForm : Form
    {
        private IButton NotReallyButton => ElementFactory.GetButton(By.XPath("//button[contains(text(),'Not really')]"), "Not Really");

        public CookiesForm() : base(By.XPath("//*[contains(@class,'cookies__message')]"), "Cookies Form")
        { }

        public void ClickNotReallyButton() => NotReallyButton.Click();
    }
}
