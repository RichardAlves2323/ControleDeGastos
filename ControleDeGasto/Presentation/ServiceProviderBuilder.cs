using ControleDeGasto.Domain.Interfaces.Repositories;
using ControleDeGasto.Domain.Interfaces.Services;
using ControleDeGasto.Domain.Services;
using ControleDeGasto.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeGasto.Presentation
{
    internal static class ServiceProviderBuilder
    {
        public static IServiceProvider Build()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<Form_Home>();
            serviceCollection.AddSingleton<CategoryRepository, CategoryRepositoryByEntityFramework>();
            serviceCollection.AddSingleton<TransactionRepository, TransactionRepositoryByEntityFramework>();
            serviceCollection.AddSingleton<ICategoryService, CategoryService>();
            serviceCollection.AddSingleton<ITransactionService, TransactionService>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
