namespace MyFramework.Factories
{
    public abstract class InternalFactoryDecorator<T, U, W> : IInternalRouteFactory<T, U, W>
    {
        protected readonly IInternalRouteFactory<T, U, W> Child;

        public InternalFactoryDecorator(IInternalRouteFactory<T, U, W> child)
        {
            Child = child;
        }

        public abstract T Create(IIdentifier<U> id, IIdentifier<W> objectId);
    }
}