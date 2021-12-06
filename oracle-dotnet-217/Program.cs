using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace oracle_dotnet_217
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args).ConfigureServices(ConfigureServices);
		}

		public static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
		{
			services.AddDbContext<TestDbContext>(options => options.UseOracle("DATA SOURCE=localhost;PASSWORD=test;USER ID=test", oracleOptions =>
			{
				oracleOptions.MigrationsHistoryTable("__MigrationHistory", "TESTSCHEMA");
				oracleOptions.UseOracleSQLCompatibility("11");
			}));
		}
	}
}
