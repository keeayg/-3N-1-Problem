using System.Collections.Generic;

namespace _3N_1_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Text and Read Number Section
            int choice = Start();

            //While Condition
            bool choiceIsTrue = false;
            if (!(choice == null))
            {
                choiceIsTrue = true;
            }

            //Divisibility Check By 2
            bool IsDouble(int a, int b)
            {
                bool DoubleIsTrue = false;
                int result = a % b;
                if (result == 0)
                {
                    DoubleIsTrue = true;
                }
                return DoubleIsTrue;
            }

            int newNUm;
            newNUm = choice;

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
                            bb = IsDouble(newNUm, 2);
                        }
                    }
                    else
                    {
                        newNUm = ((newNUm * 3) + 1); Console.WriteLine($"new number: " + newNUm);
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

            }
        }
        private static int Start()
        {
            Console.WriteLine("3x+1 PROBLEM");
            Console.WriteLine();
            Console.WriteLine("The Collatz Conjecture can be stated as: \nusing the reduced Collatz function C(n) = (3n+1)/2^x where 2^x is the largest power of 2 that divides 3n+1,\nany odd integer n will eventually reach 1 in j iterations such that C^j(n) = 1.");
            Console.WriteLine();
            Console.WriteLine("Pick a number:");
            Console.WriteLine("Waiting insert...");
            var choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}



