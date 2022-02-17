﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
               1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
               By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
             */

            int term1 = 1;
            int term2 = 2;
            int term3 = 0;
            int sum = 0;
            
            do
            {
                if (term2 % 2 == 0)
                {
                    sum += term2;
                }
                term3 = term1 + term2;
                term1 = term2;
                term2 = term3;
                if (term1 + term2 > 4000000)
                {
                    if (term2 % 2 == 0)
                    {
                        sum += term2;
                    }
                }
                Console.WriteLine(term1 + "," + term2);
            } while (term1 + term2 < 4000000);

            Console.WriteLine("\nSum of even-valued terms: " + sum);
        }
    }
}