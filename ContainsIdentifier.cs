using System.Runtime.CompilerServices;

namespace MyFramework.Factories
{
    public readonly struct ContainsIdentifier<TId> : IIdentifier<TId> where TId : IContains<TId>
    {
        private readonly TId _value;

        public ContainsIdentifier(TId value)
        {
            _value = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TId Value()
        {
            return _value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new bool Equal(TId id)
        {
            return _value.Contains(id);
        }
    }
}