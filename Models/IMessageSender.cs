namespace PostmarkDemo.Models
{
    public interface IMessageSender
    {
        string SendMessage(string email);
    }
}