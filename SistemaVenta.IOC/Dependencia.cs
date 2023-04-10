using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using SistemVenta.DAL.Interfaces;
using SistemVenta.DAL.Implementacion;
//using SistemaVenta.BLL.Implementacion;
//using SistemaVenta.BLL.Interfaces;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbventaContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });

            services.AddTransient(typeof(IGenericRepositrory<>), typeof(GenericRepository<>));
            services.AddScoped<IVentaRepository, VentaRepository>();
        }
    }
}
