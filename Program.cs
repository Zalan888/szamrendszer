using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    internal class Program
    {
        public static List<int> conversion = new List<int>();
        public static int inn = input();
        static int input()
        {
            Console.WriteLine("Kérem adjon meg egy számot!");
            return Convert.ToInt32(Console.ReadLine()); 
        }

        static void conv()
        {
            for (int i = 0; inn > 0; i++)
            {
                conversion.Add(inn%2);
                inn /= 2;
            }
            conversion.Reverse();
        }
        static void Main(string[] args)
        {
            conv();
            foreach (int i in conversion)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
