using System;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = factorial(n);
        Console.WriteLine(result);
    }

    static int factorial(int n) {
        if (n==1) return 1;
        return factorial(n-1) * n;     
    }   
}