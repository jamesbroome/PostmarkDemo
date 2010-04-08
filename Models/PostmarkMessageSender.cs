using PostmarkDotNet;
using PostmarkDotNet.Validation;

namespace PostmarkDemo.Models
{
    public class PostmarkMessageSender : IMessageSender
    {
        private readonly IConfigurationSource _configuration;

        public PostmarkMessageSender(IConfigurationSource configuration)
        {
            _configuration = configuration;
        }

        public string SendMessage(string email)
        {
            var client = new PostmarkClient(_configuration.ServerToken);

            try
            {
                var response = client.SendMessage(BuildMessage(email));

                if (response.Status != PostmarkStatus.Success)
                {
                    return response.Message;
                }
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }

            return "Message sent successfully!";
        }

        private PostmarkMessage BuildMessage(string email)
        {
            return new PostmarkMessage
                       {
                           From =_configuration.FromAddress,
                           To = email,
                           Subject = "Postmark ASP.NET MVC Demo",
                           HtmlBody = "Hello!",
                           TextBody = "Hello!",
                       };
        }
    }
}