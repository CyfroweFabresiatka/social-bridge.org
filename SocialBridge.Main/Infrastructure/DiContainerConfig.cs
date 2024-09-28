using Microsoft.EntityFrameworkCore;
using SocialBridge.Main.Data;

namespace SocialBridge.Main.Infrastructure
{
    public class DiContainerConfig
    {
        public static void AddServices(IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<ISocialBridgeAssembly>());
        }

        public static void AddDatabase(IServiceCollection services, ConfigurationManager configurationManager)
        {
            var connectionString = configurationManager.GetConnectionString("DefaultConnection") ??
                                   throw new InvalidOperationException(
                                       "Connection string not found.");
            services.AddDbContext<AppDbContext>(options => { options.UseNpgsql(connectionString); });
        }
    }
}
