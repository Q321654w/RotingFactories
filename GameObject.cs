namespace MyFramework.Factories
{
    public class GameObject<T>
    {
        private readonly IIdentifier<T> _id;

        public GameObject(IIdentifier<T> id)
        {
            _id = id;
        }
    }
}