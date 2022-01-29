using DGLI.Bank;
using DGLI.Bank.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;

Application.SetHighDpiMode(HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);

var services = new ServiceCollection();
ConfigureServices(services);

var configuration = BuildConfiguration();
services.Configure<Settings>(options => configuration.GetSection("Settings").Bind(options));

using var serviceProvider = services.BuildServiceProvider();
var loginForm = serviceProvider.GetRequiredService<LoginForm>();
Application.Run(loginForm);

static void ConfigureServices(ServiceCollection services)
{
    services.AddScoped<LoginForm>();
    services.AddScoped<TransactionsForm>();
    services.AddScoped<CongratulationsForm>();
    services.AddScoped<IncorrectPasswordForm>();
}

static IConfiguration BuildConfiguration()
{
    var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

    return builder.Build();
}