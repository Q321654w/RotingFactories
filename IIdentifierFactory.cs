namespace MyFramework.Factories
{
    public interface IIdentifierFactory<W>
    {
        IIdentifier<W> GetUniqId();
    }
}