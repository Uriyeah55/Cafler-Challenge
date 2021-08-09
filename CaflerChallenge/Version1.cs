using System;

namespace CaflerChallenge
{
    class Version1

    {
        private static void Pep (string[] args)
        {
            int MAX_NUMBER = 1000;

            Console.WriteLine("¿How many validations will be checked?");
            int validationsNum = Int32.Parse(Console.ReadLine());

            int[] num = new int[validationsNum];
            string[] str = new string[validationsNum];

            for (int cont = 0; cont < validationsNum; cont++)
            {
                Console.WriteLine("Assign a number");
                num[cont] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Assign a string to numbers divisible by said number");
                str[cont] = Console.ReadLine();
            }

            for (int cont = 1; cont <= 1000; cont++)
            {
                string output = "";

                for (int currentNumber = 0; currentNumber < validationsNum; currentNumber++)
                {
                    if (cont % num[currentNumber] == 0)
                    {
                        output += str[currentNumber];
                    }
                }
                if (output == "")
                {
                    output += cont.ToString();
                }

                Console.WriteLine(output);
            }

        }
    }
}
    

