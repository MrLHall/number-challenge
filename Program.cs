using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace number_challenge
{
    internal class Program
    {static int[] numberbase(int number, int Base)
        {
            int[] BinaryArray = new int[8];
            for (int i = 7; i>=0; i--) 
            {
                Console.WriteLine(number);
                BinaryArray[i] = number % Base;
                Console.WriteLine(BinaryArray[i]);
                number = (number/Base);
            }
            return BinaryArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the denary number you want to convert");
            int DenaryNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the base of number system you want to convert the denary number to");
            int BaseNum = Convert.ToInt32(Console.ReadLine());
            int[] ConvertionArray = numberbase(DenaryNum,BaseNum);
            for (int i= 0;i<=7;i++)
            {
                Console.Write(ConvertionArray[i]);
            }
            Console.WriteLine();
        }
    }
}
