using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from_Hex_to_Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която въвежда стойност в
            //deseti4en формат(0x##) и я
            //преобразува в shestnaisetichen формат, след което
            //извежда стойността.
            int number = int.Parse(Console.ReadLine());
            int leftOver = 0;
            while (number > 0)
            {
                leftOver = number % 2;
                Console.Write(leftOver);
                number = number / 2;
                Console.WriteLine(" ");
            }

        }
    }
}
