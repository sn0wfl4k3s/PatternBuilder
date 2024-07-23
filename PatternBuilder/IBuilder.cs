namespace PatternBuilder;

public interface IBuilder<T> where T : class
{
    T Build();
}