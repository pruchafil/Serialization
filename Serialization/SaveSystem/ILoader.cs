namespace Serialization.SaveSystem;

internal interface ILoader<T>
{
    internal string Path { get; }

    T Data { get; }
}