using System.Globalization;
using System.Web.Mvc;

namespace MVCModels.Infrastructure
{
    public class CountryValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return prefix.ToLower().IndexOf("country", System.StringComparison.Ordinal) > -1;
        }

        public ValueProviderResult GetValue(string key)
        {
            if (ContainsPrefix(key))
            {
                return new ValueProviderResult("USA","USA", CultureInfo.InvariantCulture);
            }

            return null;
        }
    }
}