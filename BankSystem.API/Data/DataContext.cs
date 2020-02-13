using BankSystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base (options) {}

    public DbSet<Client> Clients { get; set; }
    public DbSet<Disability> Disabilities { get; set; }
    public DbSet<LivingPlaceCity> LivingPlaceCities { get; set; }
    public DbSet<MaritalStatus> MaritalStatuses { get; set; }
    public DbSet<Nationality> Nationalities { get; set; }
    public DbSet<ResidencePermitCity> ResidencePermitCities  { get; set; }
  }
}