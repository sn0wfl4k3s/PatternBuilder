namespace PatternBuilder;

public class EmailBuilder : Builder<Email>
{
    public EmailBuilder AddBody(string content)
    {
        _instance.Body = content;
        return this;
    }

    public EmailBuilder AddFrom(string address)
    {
        _instance.From = address;
        return this;
    }

    public EmailBuilder AddSubject(string title)
    {
        _instance.Subject = title;
        return this;
    }

    public EmailBuilder AddTo(string address)
    {
        _instance.To = address;
        return this;
    }
}