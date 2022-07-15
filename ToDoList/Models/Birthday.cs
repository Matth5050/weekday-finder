using System;
using System.Collections.Generic;

namespace Mo.Models
{
  public class Birthday
  {
    public int Year { get; set; }
    
    // constructor
    public Birthday(int dob)
    {
      Year = dob;
    }

    public void age() {
      int currentYear = 2022;
      int finalAge = currentYear - Year;
      Console.WriteLine(finalAge);
    }
  }
}