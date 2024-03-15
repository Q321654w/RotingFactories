namespace MyFramework.Factories
{
    public interface IFactoryObjectCache<W>
    {
        void Remove(IIdentifier<W> objectId);
    }
}