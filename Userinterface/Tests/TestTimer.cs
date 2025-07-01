using Aquality.Selenium.Browsers;
using UserinterfaceTests.TestsData.TestDataManagers;

namespace UserinterfaceTests.Tests
{
    public class TestTimer : BaseTestPages
    {
        [Test]
        public void TestActionsWithTimer()
        {
            AqualityServices.Logger.Info("Start test \"TestActionsWithTimer\"");

            AqualityServices.Logger.Info("Check if Home page is open");
            Assert.That(HomePage.State.IsDisplayed, "Home page was not opened");

            HomePage.ClickHereLink();
            AqualityServices.Logger.Info("Check if Page with forms is open");
            Assert.That(PageWithForms.State.IsDisplayed, "Page with forms was not opened");

            string timer = PageWithForms.GetTimerValueString();
            AqualityServices.Logger.Info($"Check if timer on page {timer} is equal to {TestDataManager.TimerStart}");
            Assert.That(timer, Is.EqualTo(TestDataManager.TimerStart), $"Timer on page {timer} is not equal to {TestDataManager.TimerStart}");
        }
    }
}