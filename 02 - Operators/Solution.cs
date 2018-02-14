using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
  static void Main(string[] args)
  {    
    double mealCost = 0.0;
    double tipPercent = 0;
    double taxPercent = 0;
    string rawInput = "";
    double totalCost = 0;
      
    rawInput = Console.ReadLine();
    mealCost = double.Parse(rawInput);
      
    rawInput = Console.ReadLine();
    tipPercent = int.Parse(rawInput);
      
    rawInput  = Console.ReadLine();
    taxPercent = int.Parse(rawInput);

    tipPercent = tipPercent/100 * mealCost;
    taxPercent = taxPercent/100 * mealCost;
    totalCost  = mealCost + tipPercent + taxPercent;
    totalCost   += 0.5;
      
    Console.WriteLine("The total meal cost is {0} dollars.", (int)totalCost);
  }  
}