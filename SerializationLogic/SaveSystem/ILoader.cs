namespace Serialization.SaveSystem
{
    internal interface ILoader<T>
    {
        string Path { get; }

        T Data { get; }
    }
}