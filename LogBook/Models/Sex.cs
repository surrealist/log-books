using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
  public enum Sex
  {
    Unknown = 0,
    Male = 1,
    Female = 2,

    // user don't want to tell us.
    Unspecified = 999
  }
}
