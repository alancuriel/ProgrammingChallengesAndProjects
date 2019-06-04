using System;
using System.Text.RegularExpressions;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            bool getInput = true;
            int n = 0;
            while(getInput)
            {
                Console.WriteLine("Type a positive integar n to get all numbers under n that are prime.");
                string input = Console.ReadLine();
                if (isNumber(input))
                {
                    n = int.Parse(input);
                    getInput = false;
                }
                else
                {
                    Console.WriteLine("Not a valid integar try again!");
                }
            }

            bool[] prime = new bool[n+1];

        for(int i = 0; i < n; i++) 
        {
             prime[i] = true; 
        }

        for(int p = 2; p*p <= n; p++) 
        { 
             
            if(prime[p]) 
            { 
                
                for(int i = p*p; i <= n; i += p) 
                {   
                    prime[i] = false; 
                } 
            }
        } 
          
        
        for(int i = 2; i <= n; i++) 
        { 
            if(prime[i]) 
            {
                Console.Write(i + " "); 
            }
        } 


            Console.ReadKey();
        }

        private static bool isNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}
