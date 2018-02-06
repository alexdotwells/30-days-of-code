using System;

class Solution {
    static void Main(String[] args) {
        // Declare integer, double, and String variables.
        int i2 = new int();
        double d2 = new double();
        string s2 = "";

        // Read and save an integer, double, and String to variables.
        i2 = int.Parse(Console.ReadLine());
        d2 = double.Parse(Console.ReadLine());
        s2 = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + i2);

        // Print the sum of the double variables on a new line.
        double dSum = d + d2;
        Console.WriteLine(dSum.ToString("0.0"));

        // Concatenate and print the String variables on a new line
        // The 's' variable will printed first.
        Console.WriteLine(s + s2);
    }
}