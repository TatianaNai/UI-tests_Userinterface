using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTests.Forms
{
    public class HelpForm : Form
    {
        private IButton SendToBottomButton => ElementFactory.GetButton(By.XPath("//button[contains(@class,'send-to-bottom')]"), "Send to Bottom");

        public HelpForm() : base(By.XPath("//*[contains(@class,'help-form__title')]"), "Help Form")
        { }

        public void ClickSendToBottomButton() => SendToBottomButton.Click();
    }
}
