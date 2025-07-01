using Aquality.Selenium.Browsers;

namespace UserinterfaceTests.Tests
{
    public class TestCookiesForm : BaseTestPages
    {
        [Test]
        public void TestActionsWithCookies()
        {
            AqualityServices.Logger.Info("Start test \"TestActionsWithCookies\"");

            AqualityServices.Logger.Info("Check if Home page is open");
            Assert.That(HomePage.State.IsDisplayed, "Home page was not opened");

            HomePage.ClickHereLink();
            AqualityServices.Logger.Info("Check if Page with forms is open");
            Assert.That(PageWithForms.State.IsDisplayed, "Page with forms was not opened");

            AqualityServices.Logger.Info("Check if Cookies Form is open");
            Assert.That(PageWithForms.IsCookiesFormOpened(), "Cookies Form was not opened");
            PageWithForms.CookiesForm.ClickNotReallyButton();
            AqualityServices.Logger.Info("Check if Cookies Form is close");
            Assert.That(PageWithForms.IsCookiesFormClosed(), "Cookies Form was not closed");
        }
    }
}