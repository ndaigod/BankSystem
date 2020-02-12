using BankSystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base (options) {}

    public DbSet<Client> Clients  { get; set; }
  }
}