using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Petconnect.Infrastructure.Data.Context;
public class ContextFactory : IDesignTimeDbContextFactory<DataContext> {
    public DataContext CreateDbContext(string[] args) {
        var connectionString = "Host=localhost;Port=5433;Database=petconnect;Username=roberto;Password=petconnect2024";

        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseNpgsql(connectionString);

        return new DataContext(optionsBuilder.Options);
    }
}
