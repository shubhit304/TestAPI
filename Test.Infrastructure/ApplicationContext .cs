using Test.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Test.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        private readonly IConfiguration _configuration;

        public ApplicationContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseOracle("User Id=haritabh;Password=123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=172.16.4.46)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orclpdb)))");
            optionsBuilder.UseOracle(_configuration.GetConnectionString("OracleConn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}