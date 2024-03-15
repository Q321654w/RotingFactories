using System.Collections.Generic;

namespace MyFramework.Factories
{
    public class InternalArrayRouteFactory<T, U, W> : IInternalRouteFactory<T, U, W>
    {
        private readonly Pair<U, IRouteFactory<T, U>>[] _internalFactories;

        public InternalArrayRouteFactory(Dictionary<U, IRouteFactory<T, U>> internalFactories) : this(
            internalFactories.ToPairs())
        {
        }

        public InternalArrayRouteFactory(Pair<U, IRouteFactory<T, U>>[] internalFactories)
        {
            _internalFactories = internalFactories;
        }

        public T Create(IIdentifier<U> id, IIdentifier<W> objectId)
        {
            foreach (var pair in _internalFactories)
            {
                if (id.Equal(pair.Key))
                    return pair.Value.Create(id);
            }

            return default;
        }
    }
}