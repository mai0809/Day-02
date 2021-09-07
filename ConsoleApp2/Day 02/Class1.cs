using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Day_02
{
    class Class1
    {
        static bool checkPrime(int numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return false;
            }
            for (int i = 2;
                     i * i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

  
        static int primeSum(int l, int r)
        {
            int sum = 0;
            for (int i = r; i >= l; i--)
            {

                // Check for prime
                bool isPrime = checkPrime(i);
                if (isPrime)
                {

                    // Sum the prime number
                    sum = sum + i;
                }
            }
            return sum;
        }
        
        public static void Main()
        {
            int l = 4, r = 13;

            
            Console.Write(primeSum(l, r));
        }
    }






}