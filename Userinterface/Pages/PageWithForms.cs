using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UserinterfaceTests.Forms;

namespace UserinterfaceTests.Pages
{
    public class PageWithForms : Form
    {
        public LoginForm LoginForm => new();
        public AvatarInterestsForm AvatarInterestsForm => new();
        public PersonalDetailsForm PersonalDetailsForm => new();
        public HelpForm HelpForm => new();
        public CookiesForm CookiesForm => new();
        private ILabel TimerLabel => ElementFactory.GetLabel(By.XPath("//*[contains(@class,'timer')]"), "Timer");
        private const string TextInTimerSplitter = ":";
        private const int SecInMinute = 60;

        public PageWithForms() : base(By.XPath("//*[contains(@class,'timer')]"), "Page With Forms")
        { }

        public bool IsLoginFormOpened()
        {
            LoginForm.State.WaitForDisplayed();
            return LoginForm.State.IsDisplayed;
        }

        public bool IsAvatarInterestsFormOpened()
        {
            AvatarInterestsForm.State.WaitForDisplayed();
            return AvatarInterestsForm.State.IsDisplayed;
        }

        public bool IsPersonalDetailsFormOpened()
        {
            PersonalDetailsForm.State.WaitForDisplayed();
            return PersonalDetailsForm.State.IsDisplayed;
        }

        public bool IsHelpFormOpened()
        {
            HelpForm.State.WaitForDisplayed();
            return HelpForm.State.IsDisplayed;
        }

        public bool IsHelpFormClosed()
        {
            HelpForm.State.WaitForNotDisplayed();
            return !HelpForm.State.IsDisplayed;
        }

        public bool IsCookiesFormOpened()
        {
            CookiesForm.State.WaitForDisplayed();
            return CookiesForm.State.IsDisplayed;
        }

        public bool IsCookiesFormClosed()
        {
            CookiesForm.State.WaitForNotDisplayed();
            return !CookiesForm.State.IsDisplayed;
        }

        public string GetTimerValueString() => TimerLabel.Text;

        public void WaitTimerValueByInterval(int intervalSec)
        {
            int timerCurrentValue = GetTimerValueInt();
            int timerEndValue = (timerCurrentValue + intervalSec) % SecInMinute;

            while (timerCurrentValue != timerEndValue)
            {
                timerCurrentValue = GetTimerValueInt();
            }
        }

        private int GetTimerValueInt()
        {
            string timerString = GetTimerValueString();

            if (!int.TryParse(timerString.Split(TextInTimerSplitter).LastOrDefault(), out int seconds))
            {
                throw new Exception($"Unable to convert {timerString} to number");
            }

            return seconds;
        }
    }
}
