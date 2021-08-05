using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are not male");
            }


            Console.ReadLine();
        }
    }
}
