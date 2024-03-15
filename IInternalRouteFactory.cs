namespace MyFramework.Factories
{
    public interface IInternalRouteFactory<T, U, W>
    {
        T Create(IIdentifier<U> id, IIdentifier<W> objectId);
    }
}