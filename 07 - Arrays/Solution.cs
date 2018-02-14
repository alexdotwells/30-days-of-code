using System;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        Array.Reverse(arr);
        
        foreach(int numb in arr)
        {
            Console.Write(numb.ToString() + ' ');
        }
    }
}