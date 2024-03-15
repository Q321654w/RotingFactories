using System.Collections.Generic;

namespace MyFramework.Factories
{
    public abstract class InternalFactoryCache<T, U, W> : InternalFactoryDecorator<T, U, W>, IFactoryObjectCache<W>
    {
        private readonly Dictionary<IIdentifier<W>, T> _cachedInstances;

        public InternalFactoryCache(IInternalRouteFactory<T, U, W> child,
            Dictionary<IIdentifier<W>, T> cachedInstances) : base(child)
        {
            _cachedInstances = cachedInstances;
        }

        public override T Create(IIdentifier<U> id, IIdentifier<W> objectId)
        {
            if (_cachedInstances.TryGetValue(objectId, out var instance))
                return instance;

            instance = Child.Create(id, objectId);
            _cachedInstances[objectId] = instance;
            return instance;
        }

        public void Remove(IIdentifier<W> objectId)
        {
            _cachedInstances.Remove(objectId);
        }
    }
}