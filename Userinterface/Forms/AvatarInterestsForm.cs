using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTests.Forms
{
    public class AvatarInterestsForm : Form
    {
        private IButton UploadButton => ElementFactory.GetButton(By.XPath("//*[contains(text(),'upload')]"), "Upload");
        private IButton NextButton => ElementFactory.GetButton(By.XPath("//button[contains(text(),'Next')]"), "Next");
        private IList<ICheckBox> InterestsCheckBoxes => ElementFactory.FindElements<ICheckBox>(By.XPath("//*[contains(@class,'checkbox__label') and not(contains(@for,'selectall'))]"));
        private ICheckBox UnselectallCheckBox => ElementFactory.GetCheckBox(By.XPath("//*[@for='interest_unselectall']"), "Unselectall");
        
        public AvatarInterestsForm() : base(By.XPath("//*[contains(@class,'page-indicator') and contains(text(),'2')]"), "Avatar Interests Form")
        { }

        public void SelectInterestsByNumbers(List<int> numbers)
        {
            UnselectallCheckBox.Click();
            foreach (int number in numbers)
            {
                InterestsCheckBoxes[number - 1].Click();
            }
        }

        public void ClickUploadButton() => UploadButton.Click();

        public void ClickNextButton() => NextButton.Click();
    }
}
