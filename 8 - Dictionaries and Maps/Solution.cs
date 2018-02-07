using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        var phoneBook = new Dictionary<string,int>();
        
        var n = int.Parse(Console.ReadLine());

        for (int i=0; i<n; i++) 
        {        
            var input = Console.ReadLine().Split(' ');
            var nam = input[0];
            var number = int.Parse(input[1]);
            
            phoneBook.Add(nam, number);
        }
        
        for (int i=0; i<n; i++) 
        {
            var searchName = Console.ReadLine();
            if (phoneBook.ContainsKey(searchName))
            {
                var phoneNumber = phoneBook[searchName];
                Console.WriteLine($"{searchName}={phoneNumber}");
            }
            else 
            {
                Console.WriteLine("Not found");
            }
        }
        
    }
}