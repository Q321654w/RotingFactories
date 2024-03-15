namespace MyFramework.Factories
{
    public static class StringExtensions
    {
        public static IIdentifier<string> ToContainsIdentifier(this string str)
        {
            return new StringContainsIdentifier(str);
        }
    }
}