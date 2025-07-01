using Aquality.Selenium.Browsers;
using UserinterfaceUtilities.SettingsManagers;

namespace UserinterfaceTests.Tests
{
    abstract public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.GoTo(ConfigManager.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Quit();
        }
    }
}