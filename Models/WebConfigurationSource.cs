using System.Web.Configuration;

namespace PostmarkDemo.Models
{
    public class WebConfigurationSource : IConfigurationSource
    {
        public string ServerToken
        {
            get { return WebConfigurationManager.AppSettings["ServerToken"];  }
        }

        public string FromAddress
        {
            get { return WebConfigurationManager.AppSettings["From"]; }
        }
    }
}