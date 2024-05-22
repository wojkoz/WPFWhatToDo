using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace WPFWhatToDo
{
    public partial class App : Application
    {
        public static IHost? Apphost { get; private set; }

        public App()
        {
            Apphost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<MainPageViewModel>();
                })
            .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await Apphost!.StartAsync();

            var startupForm = Apphost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await Apphost!.StopAsync();
            base.OnExit(e);
        }
    }

}
