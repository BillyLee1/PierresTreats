using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
  public class PierresTreatsContext : DbContext
  {
    public PierresTreatsContext(DbContextOptions options) : base(options) { }
  }
}
