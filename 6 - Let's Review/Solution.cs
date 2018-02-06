using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution {
    static void Main(String[] args) {
        /* Read input from STDIN. */
        int inputStrCount = int.Parse(Console.ReadLine());
        
        string s;
        int l;
        
        StringBuilder even = new StringBuilder();
        StringBuilder odd = new StringBuilder();
        
        for(int i=1; i <= inputStrCount; i++) 
        { 
            s = Console.ReadLine();
            l = s.Length;
                
            for(int j=0; j < l; j++)
            {
                if(j % 2 == 0) {
                    even.Append(s[j]);           
                } else {
                    odd.Append(s[j]);
                }
                
            }
            
            /* Print output to STDOUT. */            
            Console.WriteLine(even.Append(" ").Append(odd));
            even.Length = 0;
            odd.Length = 0;
        }
                
        
    }
}