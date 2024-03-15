namespace MyFramework.Factories
{
    public class CacheControl<TResult, TId, TIdFactory> : InternalFactoryDecorator<TResult, TId, TIdFactory>
    {
        private readonly IFactoryObjectCache<TIdFactory>[] _caches;

        public CacheControl(IInternalRouteFactory<TResult, TId, TIdFactory> child, IFactoryObjectCache<TIdFactory>[] caches) : base(child)
        {
            _caches = caches;
        }

        public override TResult Create(IIdentifier<TId> id, IIdentifier<TIdFactory> objectId)
        {
            var instance = Child.Create(id, objectId);

            foreach (var cache in _caches)
                cache.Remove(objectId);

            return instance;
        }
    }
}