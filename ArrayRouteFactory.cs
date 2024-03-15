using System.Collections.Generic;

namespace MyFramework.Factories
{
    public class ArrayRouteFactory<TResult, TId> : IRouteFactory<TResult, TId>
    {
        private readonly Pair<TId, IRouteFactory<TResult, TId>>[] _internalFactories;

        public ArrayRouteFactory(Dictionary<TId, IRouteFactory<TResult, TId>> internalFactories) : this(
            internalFactories.ToPairs())
        {
        }

        public ArrayRouteFactory(Pair<TId, IRouteFactory<TResult, TId>>[] internalFactories)
        {
            _internalFactories = internalFactories;
        }

        public TResult Create(IIdentifier<TId> id)
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