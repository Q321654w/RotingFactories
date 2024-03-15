namespace MyFramework.Factories
{
    public interface IIdentifier<T>
    {
        T Value();
        bool Equal(T id);
    }
}