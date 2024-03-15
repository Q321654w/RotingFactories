namespace MyFramework.Factories
{
    public struct Pair<TKey, TValue>
    {
        private readonly TKey _key;
        private readonly TValue _value;

        public TKey Key => _key;
        public TValue Value => _value;

        public Pair(TKey key, TValue value)
        {
            _key = key;
            _value = value;
        }
    }
}