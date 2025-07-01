namespace UserinterfaceUtilities.Utilities
{
    public static class RandomGeneratorUtils
    {
        private const string RandomSymbols = "012346789ABCDEFGHJKLMNPQRTUVWXYZabcdefghjkmnpqrtuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЭЮЯабвгдеёжзийклмнопрстуфхцчшщьыэюя";
        private const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЭЮЯ";
        private const string CyrillicSymbols = "абвгдеёжзийклмнопрстуфхцчшщьыэюя";
        private const string Digits = "0123456789";

        public static List<int> GetRandomListIntInRange(int limit, int minValue, int maxValue)
        {
            Random random = new();
            List<int> numbers;

            if(minValue < maxValue)
            {
                numbers = Enumerable
                        .Range(minValue, maxValue - minValue + 1)
                        .OrderBy(num => random.Next()).ToList();
            }
            else
            {
                throw new Exception($"Unable to create List of numbers with parametrs minValue: {minValue}, maxValue: {maxValue}");
            }

            if (limit <= numbers.Count && limit > 0)
            {
                numbers = numbers.Take(limit).ToList();
            }
            else
            {
                throw new Exception($"Unable to take {limit} elements from List of numbers with {numbers.Count} elements");
            }

            return numbers;
        }

        public static int GetRandomNumber(int minValue, int maxValue)
        {
            Random random = new();

            return random.Next(minValue, maxValue + 1);
        }

        public static string GetRandomString(int amountSymbolsInString)
        {
            Random random = new();

            char[] message = new char[amountSymbolsInString];
            for (int i = 0; i < message.Length; i++)
            {
                message[i] = RandomSymbols[random.Next(RandomSymbols.Length)];
            }

            return new string(message); 
        }

        public static string GetStringForPassword(int minLength, int maxLength, string text)
        {
            Random random = new();
            int length = random.Next(minLength, maxLength + 1);

            char[] message = new char[length];
            message[0] = Uppercase[random.Next(Uppercase.Length)];
            message[1] = CyrillicSymbols[random.Next(CyrillicSymbols.Length)];
            message[2] = Digits[random.Next(Digits.Length)];
            message[3] = text[random.Next(text.Length)];

            for (int i = 4; i < length; i++)
            {
                message[i] = RandomSymbols[random.Next(RandomSymbols.Length)];
            }

            return new string(message.OrderBy(x => random.Next()).ToArray());
        }
    }
}
