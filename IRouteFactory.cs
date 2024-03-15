namespace MyFramework.Factories
{
    public interface IRouteFactory<out TResult, TId>
    {
        TResult Create(IIdentifier<TId> id);
    }
}