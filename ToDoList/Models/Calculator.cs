using System;
using System.Collections.Generic;

namespace Mo.Models
{
  public class Month
  {
    public int Yue { get; set; }

     public Month(int time)
      {
        Yue = time;
      }

    public void Ok(int input)
    {
    int newInput = input;
    int BirthdayNext = newInput + 1;
    if (BirthdayNext == 2)
    {
      Console.WriteLine("February");
    }  
    else if (BirthdayNext == 3) 
    {
      Console.WriteLine("March");
    } 
    else if (BirthdayNext == 4) 
    {
      Console.WriteLine("April");
    } 
    else if (BirthdayNext == 5) 
    {
      Console.WriteLine("May");
    } 
    else if (BirthdayNext == 6)
    {
      Console.WriteLine("June");
    }
    else if (BirthdayNext == 7)
    {
      Console.WriteLine("July");
    } 
    else if (BirthdayNext == 8)
    {
      Console.WriteLine("August");
    }  
    else if (BirthdayNext == 9)
    {
      Console.WriteLine("September");
    }
    else if (BirthdayNext == 10)
    {
      Console.WriteLine("October");
    }
    else if (BirthdayNext == 11)
    {
      Console.WriteLine("Novemeber");
    }
    else if (BirthdayNext == 12)
    {
      Console.WriteLine("December");
    }
    else
    {
      Console.WriteLine("You have died...sorry");
    }
  }
 
  }
}