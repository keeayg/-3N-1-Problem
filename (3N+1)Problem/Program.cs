﻿using System.Collections.Generic;

namespace _3N_1_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Text and Read Number Section
            double choice = Start();
           
            //While Condition
            bool choiceIsTrue = false;
            if (!(choice == null))
            {
                choiceIsTrue = true;
            }

            //Divisibility Check By 2
            bool IsDouble(double a, double b)
            {
                bool DoubleIsTrue = false;
                double result = a % b;
                if (result == 0)
                {
                    DoubleIsTrue = true;
                }
                return DoubleIsTrue;
            }

            double newNUm;
            newNUm = choice;

            // List 
            List<double> numbers = new List<double>();

            //While Start
            while (choiceIsTrue == true)
            {
                while (newNUm != 0 && newNUm != 1)
                {
                    bool aa = IsDouble(newNUm, 2);

                    if (aa == true)
                    {
                        bool bb = IsDouble(newNUm, 2);
                        while (bb == true)
                        {
                            newNUm = newNUm / 2;
                            Console.WriteLine($"Divided number: " + newNUm);
                            numbers.Add(newNUm);
                            bb = IsDouble(newNUm, 2);
                        }
                    }
                    else
                    {
                        newNUm = ((newNUm * 3) + 1); Console.WriteLine($"new number: " + newNUm);
                        numbers.Add(newNUm);
                    }

                }



                Console.WriteLine();
                Console.WriteLine();

                int count = 0;
                while (count < 4)
                {
                    while (newNUm != 0 && count < 4)
                    {
                        count++;
                        bool aa = IsDouble(newNUm, 2);

                        if (aa == true)
                        {
                            bool bb = IsDouble(newNUm, 2);
                            while (bb == true)
                            {
                                newNUm = newNUm / 2;
                                Console.WriteLine($"Divided number: " + newNUm);
                                bb = IsDouble(newNUm, 2);
                            }
                        }
                        else
                        {
                            newNUm = ((newNUm * 3) + 1); Console.WriteLine($"new number: " + newNUm);
                        }


                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                //Loop message 
                if (count == 4)
                {
                    choiceIsTrue = false;
                    Console.WriteLine("İt is a LOOP.");
                }


                // List Search for Biggest Number
                var top = numbers[0];
                var min = numbers[0];

                foreach (int sayi in numbers)
                {
                    if (sayi > top)
                    {
                        top = sayi;
                    }
                    if (sayi < min)
                    {
                        min = sayi;
                    }
                }

                Console.WriteLine("Top Number:{0}", top);
                Console.WriteLine("Min Number:{0}", min);
            }
        }
        private static double Start()
        {
            Console.WriteLine("3x+1 PROBLEM");
            Console.WriteLine();
            Console.WriteLine("The Collatz Conjecture can be stated as: \nusing the reduced Collatz function C(n) = (3n+1)/2^x where 2^x is the largest power of 2 that divides 3n+1,\nany odd integer n will eventually reach 1 in j iterations such that C^j(n) = 1.");
            Console.WriteLine();
            Console.WriteLine("Pick a number:");
            Console.WriteLine("Waiting insert...");
            double choice = Convert.ToDouble(Console.ReadLine());
            return choice;
        }
    }
}



