using System;

class Program {
  public static void Main (string[] args) {
    //prompts user for wind speed in mph
    Console.WriteLine ("Enter wind speed un mph: ");
    var windSpeedInput = Console.ReadLine();

    //checks if input is a number
    double windSpeed;
    if(double.TryParse(windSpeedInput, out windSpeed))
    {
      //checks wind speed value and compares and prints out the hurricane category
      switch(windSpeed)
      {
      case double hurricaneCategory when hurricaneCategory >= 157:
        Console.WriteLine("Category five hurricane");
        break;
      case double hurricaneCategory when hurricaneCategory >= 130:
        Console.WriteLine("Category four hurricane");
        break;
      case double hurricaneCategory when hurricaneCategory >= 111:
        Console.WriteLine("Category three hurricane");
        break;
      case double hurricaneCategory when hurricaneCategory >= 96:
        Console.WriteLine("Category two hurricane");
        break;
      case double hurricaneCategory when hurricaneCategory >= 74:
        Console.WriteLine("Category one hurricane");
        break;
      default:
        Console.WriteLine("Not a hurricane");
        break;
        
      }
    }
    else
    {
      //error message if input is not a number
      Console.WriteLine("Not a number");
    }
  }
}