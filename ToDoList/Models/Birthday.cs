using System;
using System.Collections.Generic;

namespace Bd.Models
{
  public class Birthday
  {
    public int Year { get; set; }
    
    // constructor
    public Birthday(int userInput)
    {
      Year = userInput;
    }

    public int age() {
      int currentYear = 2022;
      int finalAge = currentYear - Year;
      return finalAge;
      // Console.WriteLine("year");
    }
  }
}