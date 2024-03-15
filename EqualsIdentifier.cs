using System;
using System.Runtime.CompilerServices;

namespace MyFramework.Factories
{
    public readonly struct EqualsIdentifier<T> : IIdentifier<T> where T : IComparable
    {
        private readonly T _value;

        public EqualsIdentifier(T value)
        {
            _value = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Value()
        {
            return _value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new bool Equal(T id)
        {
            return _value.CompareTo(id) == 0;
        }
    }
}