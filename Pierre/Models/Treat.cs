using System.Collections.Generic;

namespace Pierre.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntries = new HashSet<TreatFlavor>();
    }
    public int TreatId { get; set; }
    public string Type { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntries { get; }
  }
}