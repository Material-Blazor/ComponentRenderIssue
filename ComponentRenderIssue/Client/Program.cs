using Material.Blazor;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ComponentRenderIssue.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMBServices(
                toastServiceConfiguration: new MBToastServiceConfiguration()
                {
                    InfoDefaultHeading = "Info",
                    SuccessDefaultHeading = "Success",
                    WarningDefaultHeading = "Warning",
                    ErrorDefaultHeading = "Error",
                    Timeout = 3000,
                    MaxToastsShowing = 3,
                    CloseMethod = MBToastCloseMethod.TimeoutAndCloseButton,
                    Position = MBToastPosition.TopRight
                },
                animatedNavigationManagerServiceConfiguration: new MBAnimatedNavigationManagerServiceConfiguration()
                {
                    ApplyAnimation = true,
                    AnimationTime = 300
                }
                );

            await builder.Build().RunAsync();
        }
    }
}
