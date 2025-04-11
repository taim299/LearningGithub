using System;

namespace LearnigGithub
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            float test = 100;
            for (int i = 0; i < 1000; i++)
            {
                test -= .02f;
            }
        }
    }
}