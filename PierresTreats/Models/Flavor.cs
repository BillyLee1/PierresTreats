using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public string FlavorName { get; set; }
    public int FlavorId { get; set; }

    public List<FlavorTreat> JoinEntities { get;}
  }
}
