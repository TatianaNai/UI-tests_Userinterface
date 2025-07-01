using Microsoft.Extensions.Configuration;

namespace UserinterfaceTests.TestsData.TestDataManagers
{
    public static class TestDataManager
    {
        private const string PathToTestData = "TestsData/JsonFiles/TestData.json";

        private static IConfigurationRoot TestDataConfig => new ConfigurationBuilder()
            .AddJsonFile(PathToTestData)
            .Build();

        public static int MinLengthPassword => TestDataConfig.GetValue<int>("minLengthPassword");
        public static int MaxLengthPassword => TestDataConfig.GetValue<int>("maxLengthPassword");
        public static int TopLevelDomainMinValue => TestDataConfig.GetValue<int>("topLevelDomainMinValue");
        public static int TopLevelDomainMaxValue => TestDataConfig.GetValue<int>("topLevelDomainMaxValue");
        public static int AmountOfInterests => TestDataConfig.GetValue<int>("amountOfInterests");
        public static int InterestsMinValue => TestDataConfig.GetValue<int>("interestsMinValue");
        public static int InterestsMaxValue => TestDataConfig.GetValue<int>("interestsMaxValue");
        public static string PathToImage => TestDataConfig["pathToImage"] ?? throw new Exception("TestData \"PathToImage\" has no value");
        public static string TimerStart => TestDataConfig["timerStart"] ?? throw new Exception("TestData \"TimerStart\" has no value");
        public static int TimerIntervalInSec => TestDataConfig.GetValue<int>("timerIntervalInSec");
        public static int AmountSymbolsInEmail => TestDataConfig.GetValue<int>("amountSymbolsInEmail");
        public static int AmountSymbolsInDomain => TestDataConfig.GetValue<int>("amountSymbolsInDomain");
    }
}
