﻿using System;
using System.Diagnostics;

namespace Project01_Introduction
{
    // All organizing structures use { and } to define their boundaries
    class L1_Program
    {
        // All .NET programs begin with the main method
        // It looks like this
        static void Main(string[] args)
        {
            // example 0 - first program
            Console.WriteLine("Hello World!");
            // Console.ReadKey();
            // Debug.WriteLine("Hello World!");

            // obtaining user input
            Console.WriteLine("Please provide your input");
            string userInput = Console.ReadLine();

            // parsing to specific data types
            int inputNumber = Convert.ToInt32(userInput);

            // parsing with error handling
            Console.WriteLine("Please provide your input");
            string userInputToCheck = Console.ReadLine();

            try
            {
                int inputNumberChecked = Convert.ToInt32(userInputToCheck);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // example 1 - simple computation
            // M disambiguates between double and decimal
            decimal income = 10000000.45M;
            decimal taxRate = 0.1M;
            decimal taxLiability = income * taxRate;
            Debug.WriteLine("Tax liability is " + taxLiability);

            // example 2 - API usage
            double rate = 0.06;
            double doublingTime = Math.Log(2) / Math.Log(1 + rate);

            Debug.WriteLine("Doubling time is " + doublingTime + " years");


            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6

            //Write your code here
            int a, b, c;
            Console.WriteLine("Input the sides of the triangle");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Sides of a triangle cannot be 0");
            }
            else
            {
                double s = a + b + c / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine(area);
            }


                // example 3 - selection
                if (income < 400000)
                    taxLiability = 0;
                else
                {
                    taxRate = 0.5M;
                    taxLiability = taxRate * income;
                }

                Debug.WriteLine("Tax liability is " + taxLiability);

                // example 4 - numeric input
                string incomeInput = Console.ReadLine();

                Debug.WriteLine("Thanks, you entered " + incomeInput);

                income = Convert.ToDecimal(incomeInput);
                if (income > 400000)
                {
                    taxRate = 0.5M;
                    taxLiability = taxRate * income;
                }
                else
                {
                    taxLiability = 0;
                }

                Debug.WriteLine("Tax liability is " + taxLiability);
    

            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here
            Console.WriteLine("Input a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }



            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here

            Console.WriteLine("Enter 3 integers");
            Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(Console.ReadLine());


            // example 5 - loop
            bool stopProgram = false;

               while (stopProgram == false)
               {
                   Console.Write("Please enter income: $");
                   income = Convert.ToDecimal(Console.ReadLine());

                   if (income > 400000)
                   {
                       taxRate = 0.5M;
                       taxLiability = taxRate * income;
                   }
                   else if (income >= 0)
                   {
                       taxLiability = 0;
                   }
                   else
                   {
                       stopProgram = true;
                   }

                   Console.WriteLine("Tax liability is " + taxLiability);
               } // end while loop


            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n natural numbers.
            // Eg. n=5. sum = 1+2+3+4+5 = 15

            // Write your code here




            // Exercise 5
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            { 
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            // Write your code here




            // Exercise 6
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****

            // Write your code here
            int l = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= l; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



               // example 6 - method
               income = Convert.ToDecimal(Console.ReadLine());
               taxLiability = ComputeTaxes(income);
               Debug.WriteLine("Tax liability is " + taxLiability);


               // Exercise 7
               // Write a method that accepts a parameter (n) and returns the sum of first n natural numbers.

               // Write your code here




               // example 7 - arrays
               decimal[] incomes = new decimal[] { 100.0M, 234532, 2443245.1M, 123443 };

               for (int i = 0; i < 4; i++)
               {
                   Debug.WriteLine(incomes[i]);
               }


               // Exercise 8
               // Enter n numbers in an array and print all the even numbers.

               // Write your code here



               // Exercise 9
               // Enter n numbers in an array and find the highest and the smallest number.

               // Write your code here

           }

           static decimal ComputeTaxes(decimal income)
           {
               decimal taxLiability;
               decimal taxRate;

               if (income < 400000)
                   taxLiability = 0;
               else
               {
                   taxRate = 0.5M;
                   taxLiability = taxRate * income;
               }

               return taxLiability;
        }
    }
}