using DGLI.Bank.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGLI.Bank
{
	static class Program
	{
		public static IConfiguration Configuration { get; set; }
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var services = new ServiceCollection();

			ConfigureServices(services);

			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddEnvironmentVariables();

			Configuration = builder.Build();

			services.Configure<Settings>(options => Configuration.GetSection("Settings").Bind(options));

			using var serviceProvider = services.BuildServiceProvider();
			var loginForm = serviceProvider.GetRequiredService<LoginForm>();
			Application.Run(loginForm);
		}

		private static void ConfigureServices(ServiceCollection services)
		{
			services.AddScoped<LoginForm>();
			services.AddScoped<TransactionsForm>();
			services.AddScoped<CongratulationsForm>();
			services.AddScoped<IncorrectPasswordForm>();
		}
	}
}
