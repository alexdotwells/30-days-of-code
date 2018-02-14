using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(evalInput(N));
    }
    
    static string evalInput(int n)
    {
        //If n is odd, print Weird
        //If n is even and in the inclusive range of 2 to 5, print Not Weird       
        //If n is even and in the inclusive range of 6 to 20, print Weird
        //If n is even and greater than 20, print Not Weird
        
        if(n % 2 != 0 || (6 <= n && n <= 20)) 
        {
            return "Weird";
        } else {
            return "Not Weird";
        }
    }
}