using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Configurations;

namespace UserinterfaceUtilities.SettingsManagers
{
    public static class ConfigManager
    {
        private static ISettingsFile Settings => AqualityServices.Get<ISettingsFile>();

        public static string BaseUrl => Settings.GetValue<string>("homePageUrl");
    }
}
