using System.Collections.Generic;

namespace MyFramework.Factories
{
    public class ArrayRouteFactoryEndPoint<TResult, TId, TIdFactory> : IRouteFactory<TResult, TId>
    {
        private readonly Pair<TId, IInternalRouteFactory<TResult, TId, TIdFactory>>[] _internalFactories;
        private readonly IIdentifierFactory<TIdFactory> _identifierFactory;


        public ArrayRouteFactoryEndPoint(
            Dictionary<TId, IInternalRouteFactory<TResult, TId, TIdFactory>> internalFactories,
            IIdentifierFactory<TIdFactory> identifierFactory) : this(internalFactories.ToPairs(), identifierFactory)
        {
        }

        public ArrayRouteFactoryEndPoint(
            Pair<TId, IInternalRouteFactory<TResult, TId, TIdFactory>>[] internalFactories,
            IIdentifierFactory<TIdFactory> identifierFactory)
        {
            _internalFactories = internalFactories;
            _identifierFactory = identifierFactory;
        }

        public TResult Create(IIdentifier<TId> id)
        {
            var objectId = _identifierFactory.GetUniqId();

            foreach (var pair in _internalFactories)
            {
                if (id.Equal(pair.Key))
                    return pair.Value.Create(id, objectId);
            }

            return default;
        }
    }
}