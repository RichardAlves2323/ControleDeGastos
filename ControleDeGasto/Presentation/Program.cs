using ControleDeGasto.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeGasto.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var db = new GastoContext();
            db.Database.EnsureCreated();

            ApplicationConfiguration.Initialize();

            var serviceProvider = ServiceProviderBuilder.Build();
            var formHome = serviceProvider.GetRequiredService<Form_Home>();

            Application.Run(formHome);
        }
    }
}