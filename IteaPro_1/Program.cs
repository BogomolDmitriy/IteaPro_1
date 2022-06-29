using System;

namespace IteaPro_1
{
    class Program
    {
        static int max (int [] arrey)
        {
            int max = arrey[0];
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i]> max)
                {
                    max = arrey[i];
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
