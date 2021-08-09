using System;
using System.Collections.Generic;

namespace CaflerTest3
{
    class Version2
    {
        static int MAX_VALUE = 50;
        static void Main(string[] args)
        {
            Console.WriteLine("Number of validations:");
            int valNumber = Convert.ToInt32(Console.ReadLine());

            List<int> validList = new List<int>();
            List<string> valStringList = new List<string>();
            for (int i = 0; i < valNumber; i++)
            {
                Console.WriteLine("Checking number " + (i + 1) + "to validate");
                int num = Convert.ToInt32(Console.ReadLine());
                validList.Add(num);
                Console.WriteLine("Word to show:");
                string word = Console.ReadLine();
                valStringList.Add(word);
            }
            Console.WriteLine("==========Counting=======");

            for (int p = 1; p <= MAX_VALUE; p++)
            {
                bool found = false;
                String msg = "";
                foreach (int number in validList)
                {


                    if (p % number == 0)
                    {
                        int pus = validList.IndexOf(number);
                        msg += valStringList[pus];
                        found = true;
                    }
                }
                if (found)
                {
                    Console.WriteLine(msg);
                }
                else
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
