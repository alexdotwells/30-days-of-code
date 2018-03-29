using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var nameList = new nameList<string>();

        for (int i = 0; i < n; i++)
        {
            var tmp = Console.ReadLine().Split(' ');
            var name = tmp[0];
            var email = tmp[1];

            if (Regex.IsMatch(email, @".+@gmail\.com$"))
            {
                nameList.Add(name);
            }
        }

        nameList.Sort();

        foreach (var name in nameList)
        {
            Console.WriteLine(name);
        }
    }
}