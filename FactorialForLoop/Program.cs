﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialForLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");

            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number -1; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();
        }
    }
}
