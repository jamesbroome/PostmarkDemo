using Ninject.Modules;
using PostmarkDemo.Models;

namespace PostmarkDemo.Components
{
    public class WebModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMessageSender>().To<PostmarkMessageSender>();
            Bind<IConfigurationSource>().To<WebConfigurationSource>();
        }
    }
}