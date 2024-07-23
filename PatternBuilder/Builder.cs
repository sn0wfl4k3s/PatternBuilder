namespace PatternBuilder;

public abstract class Builder<T> where T : class, new()
{
    protected readonly T _instance;

    public Builder()
    {
        _instance = new();
    }

    public T Build() => _instance;
}