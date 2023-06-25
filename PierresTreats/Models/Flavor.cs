using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public string FlavorName { get; set; }
    public int FlavorId { get; set; }

    public List<FlavorTreat> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}
