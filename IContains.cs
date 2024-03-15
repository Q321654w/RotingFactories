namespace MyFramework.Factories
{
    public interface IContains<T>
    {
        bool Contains(T value);
    }
}