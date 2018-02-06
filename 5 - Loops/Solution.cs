using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Write a different string each iteration.
        string s;
        for (int i = 1; i < 11; i++)
        {
            // A simple format string with no alignment formatting.
            s = System.String.Format("{0} x {1} = {2}", n, i, (n * i));
            System.Console.WriteLine(s);
        }
        
        
        
    }
}