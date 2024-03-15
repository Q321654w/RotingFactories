namespace MyFramework.Factories
{
    public class SequentialIntIdentifierFactory : IIdentifierFactory<int>
    {
        private int _previousId;

        public SequentialIntIdentifierFactory(int previousId)
        {
            _previousId = previousId;
        }

        public IIdentifier<int> GetUniqId()
        {
            return new EqualsIdentifier<int>(_previousId++);
        }
    }
}