using Autofac;
using FriendStorage.UI.DataProvider;
using FriendStorage.UI.ViewModel;
using FriendStorage.UITests.ViewModel;

namespace FriendStorage.UITests.Startup
{
    public class BootStrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<NavigationViewModel>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            return builder.Build();
        }
    }
}
