using System.Runtime.CompilerServices;

namespace MyFramework.Factories
{
    public readonly struct StringContainsIdentifier : IIdentifier<string>
    {
        private readonly string _value;

        public StringContainsIdentifier(string value)
        {
            _value = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Value()
        {
            return _value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equal(string id)
        {
            return _value.Contains(id);
        }
    }
}