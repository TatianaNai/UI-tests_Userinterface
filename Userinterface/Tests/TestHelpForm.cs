using Aquality.Selenium.Browsers;

namespace UserinterfaceTests.Tests
{
    public class TestHelpForm : BaseTestPages
    {
        [Test]
        public void TestActionsWithHelpForm()
        {
            AqualityServices.Logger.Info("Start test \"TestActionsWithHelpForm\"");

            AqualityServices.Logger.Info("Check if Home page is open");
            Assert.That(HomePage.State.IsDisplayed, "Home page was not opened");

            HomePage.ClickHereLink();
            AqualityServices.Logger.Info("Check if Page with forms is open");
            Assert.That(PageWithForms.State.IsDisplayed, "Page with forms was not opened");

            AqualityServices.Logger.Info("Check if Help Form is open");
            Assert.That(PageWithForms.IsHelpFormOpened(), "Help Form was not opened");
            PageWithForms.HelpForm.ClickSendToBottomButton();
            AqualityServices.Logger.Info("Check if Help Form is close");
            Assert.That(PageWithForms.IsHelpFormClosed(), "Help Form was not closed");
        }
    }
}