using System;
using System.ComponentModel.DataAnnotations;

namespace LogBook.Models
{
  public class WardPreDivisionVisit : DivisionVisit
  {
    [StringLength(30)]
    public string WardName { get; set; }

    public DateTime TimeWardArrive { get; set; }
    public string Diagnosis { get; set; }

  }
}
