using Aquality.Selenium.Browsers;
using UserinterfaceTests.TestsData.TestDataManagers;
using UserinterfaceUtilities.Utilities;

namespace UserinterfaceTests.Tests
{
    public class TestUserCards : BaseTestPages
    {
        [Test]
        public void TestActionsWithUserCards()
        {
            AqualityServices.Logger.Info("Start test \"TestActionsWithUserCards\"");

            AqualityServices.Logger.Info("Check if Home page is open");
            Assert.That(HomePage.State.IsDisplayed, "Home page was not opened");

            HomePage.ClickHereLink();
            AqualityServices.Logger.Info("Check if Page with forms is open");
            Assert.That(PageWithForms.State.IsDisplayed, "Page with forms was not opened");
            AqualityServices.Logger.Info("Check if Login Form is open");
            Assert.That(PageWithForms.IsLoginFormOpened(), "Login Form was not opened");

            string email = RandomGeneratorUtils.GetRandomString(TestDataManager.AmountSymbolsInEmail);
            string password = RandomGeneratorUtils.GetStringForPassword(TestDataManager.MinLengthPassword, TestDataManager.MaxLengthPassword, email);
            string domain = RandomGeneratorUtils.GetRandomString(TestDataManager.AmountSymbolsInDomain);
            int topLevelDomainNumber = RandomGeneratorUtils.GetRandomNumber(TestDataManager.TopLevelDomainMinValue, TestDataManager.TopLevelDomainMaxValue);
            PageWithForms.LoginForm.FillForm(password, email, domain, topLevelDomainNumber);
            PageWithForms.LoginForm.ClickTermsConditionsCheckBox();
            PageWithForms.LoginForm.ClickNextButton();
            AqualityServices.Logger.Info("Check if Avatar Interests Form is open");
            Assert.That(PageWithForms.IsAvatarInterestsFormOpened(), "Avatar Interests Form was not opened");

            PageWithForms.AvatarInterestsForm.ClickUploadButton();
            string filePath = PathUtils.GetFullPathFromCurrentDirectory(TestDataManager.PathToImage);
            AqualityServices.Logger.Info($"Choose image: {filePath}");
            PageWithForms.WaitTimerValueByInterval(TestDataManager.TimerIntervalInSec);
            InputSimulatorUtils.SendText(filePath);
            InputSimulatorUtils.PressEnter();
            List<int> listNumbers = RandomGeneratorUtils.GetRandomListIntInRange(TestDataManager.AmountOfInterests, TestDataManager.InterestsMinValue, TestDataManager.InterestsMaxValue);
            PageWithForms.AvatarInterestsForm.SelectInterestsByNumbers(listNumbers);
            PageWithForms.AvatarInterestsForm.ClickNextButton();
            AqualityServices.Logger.Info("Check if Personal Details Form is open");
            Assert.That(PageWithForms.IsPersonalDetailsFormOpened(), "Personal Details Form was not opened");
        }
    }
}