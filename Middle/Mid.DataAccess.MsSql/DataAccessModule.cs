using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mid.Infrastructure.Interfaces.DataAccess;
using Mid.Utils.Modules;

namespace Mid.DataAccess.MsSql
{
    public class DataAccessModule : Module
    {
        public override void Load(IServiceCollection services)
        {
            services.AddDbContext<IDbContext, AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection")));
        }
    }
}
