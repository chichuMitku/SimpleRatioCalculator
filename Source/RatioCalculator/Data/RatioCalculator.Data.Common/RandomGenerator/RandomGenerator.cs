namespace RatioCalculator.Data.Common.RandomGenerator
{
    using System;
    using System.Text;

    public class RandomGenerator
    {
        private const string domain = ".com";
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const int minServerNameLength = 1;
        private const int maxServerNameLength = 10;

        private Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public string RandomString(int min, int max)
        {
            var result = new StringBuilder();

            for (int i = min; i < max + 1; i++)
            {
                result.Append(alphabet[this.RandomNumber(0, alphabet.Length - 1)]);
            }

            return result.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            var result = this.random.Next(min, max + 1);
            return result;
        }

        public string RandomMailAddress(int min = 2, int max = 15)
        {
            var result = new StringBuilder();

            result.Append(string.Format("{0}@{1}{2}", this.RandomString(min, max), this.RandomString(minServerNameLength, maxServerNameLength), domain));

            return result.ToString();
        }
    }
}
