using App;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace WinFormHdleon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<Form1>();

            Application.Run(mainForm);


            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }

        private static void ConfigureServices(ServiceCollection services) 
        { 

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("AppSettings.json", optional: false, reloadOnChange:true)
                .Build();

            services.AddDbContext<AppDbContext>(options => options.UseMySQL(configuration.GetConnectionString("DB")));

            services.AddTransient<AddBrand>();
            services.AddTransient<EditBrand>();
            services.AddTransient<AddBeer>();
            services.AddTransient<EditBeer>();
            services.AddTransient<IRepository<Brand>,BrandRepository>();
            services.AddTransient<IRepository<Beer>,BeerRepository>();

            services.AddTransient<Form1>();
            services.AddTransient<FromBrand>();
            services.AddTransient<FormNewEditBrand>();
            services.AddTransient<FormBeer>();
        }
    }
}