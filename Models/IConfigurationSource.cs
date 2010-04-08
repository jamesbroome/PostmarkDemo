namespace PostmarkDemo.Models
{
    public interface IConfigurationSource
    {
        string ServerToken { get; }
        string FromAddress { get; }
    }
}