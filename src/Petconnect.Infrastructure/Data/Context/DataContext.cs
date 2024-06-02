using Microsoft.EntityFrameworkCore;
using Petconnect.Domain.Entities;

namespace Petconnect.Infrastructure.Data.Context; 
public class DataContext : DbContext {
    public DataContext(DbContextOptions<DataContext> options) : base (options) { }

    public DbSet<AddressEntity> Address { get; set; }
    public DbSet<AnimalEntity> Animal { get; set; }
    public DbSet<ChatEntity> Chat { get; set; }
    public DbSet<CommonUserEntity> CommonUser { get; set; }
    public DbSet<EvaluationEntity> Evaluation { get; set; }
    public DbSet<MessageEntity> Message { get; set; }
    public DbSet<ServiceEntity> Service { get; set; }
    public DbSet<ServiceCategoryEntity> ServiceCategory { get; set; }
    public DbSet<ServiceProviderEntity> ServiceProvider { get; set; }
    public DbSet<ServiceRequestEntity> ServiceRequest { get; set; }
    public DbSet<SpecieEntity> Specie { get; set; }
    public DbSet<UserEntity> User { get; set; }
}
