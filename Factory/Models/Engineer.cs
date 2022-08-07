using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachince>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string EngineerSpecialty { get; set; }
    public virtual ICollection<EngineerMachince> JoinEntities { get; set; }
  }
}