using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTests.Forms
{
    public class LoginForm : Form
    {
        private IButton NextButton => ElementFactory.GetButton(By.XPath("//*[contains(text(),'Next')]"), "Next");
        private IButton OtherButton => ElementFactory.GetButton(By.XPath("//*[contains(@class,'dropdown__header')]"), "Other");
        private ICheckBox TermsConditionsCheckBox => ElementFactory.GetCheckBox(By.XPath("//*[contains(@class,'icon-check')]"), "TermsConditions");
        private ITextBox PasswordTextBox => ElementFactory.GetTextBox(By.XPath("//*[@placeholder='Choose Password']"), "Password");
        private ITextBox EmailTextBox => ElementFactory.GetTextBox(By.XPath("//*[@placeholder='Your email']"), "Email");
        private ITextBox DomainTextBox => ElementFactory.GetTextBox(By.XPath("//*[@placeholder='Domain']"), "Domain");
        private IList<ILabel> ListTopLevelDomains => ElementFactory.FindElements<ILabel>(By.XPath("//*[contains(@class,'list-item')]"));

        public LoginForm() : base(By.XPath("//*[contains(@class,'page-indicator') and contains(text(),'1')]"), "Login Form")
        { }

        public void FillForm(string password, string email, string domain, int topLevelDomainNumber)
        {
            PasswordTextBox.ClearAndType(password);
            EmailTextBox.ClearAndType(email);
            DomainTextBox.ClearAndType(domain);
            AqualityServices.Logger.Info($"Password: {password}, email: {email}, domain: {domain}");
            OtherButton.Click();
            AqualityServices.Logger.Info($"Click element: {ListTopLevelDomains[topLevelDomainNumber].Text}");
            ListTopLevelDomains[topLevelDomainNumber].Click();
        }

        public void ClickTermsConditionsCheckBox() => TermsConditionsCheckBox.Click();

        public void ClickNextButton() => NextButton.Click();
    }
}
