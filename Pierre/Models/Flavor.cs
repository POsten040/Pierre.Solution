using System.Collections.Generic;

namespace Pierre.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntries = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntries { get; }
  }
}