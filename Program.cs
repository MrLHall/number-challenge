using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace number_challenge
{
    internal class Program
    {static long[] numberbase(long number, int Base)
        {
            ArrayList binarylist = new ArrayList();
            long[] BinaryArray = new long[100]; //creates array with 8 charecters for numbers
            for (int i = 99; i>=0; i--) // starts a look counting backwards from 7 to input last index first 
            {
                //Console.WriteLine(number);
                BinaryArray[i] = number % Base; // calculates digit in convertion, starting at last index 
                //Console.WriteLine(BinaryArray[i]);
                number = (number/Base); //next number fro the next step 
            }
            return BinaryArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the denary number you want to convert");
            long DenaryNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the base of number system you want to convert the denary number to");
            int BaseNum = Convert.ToInt16(Console.ReadLine());
            long[] ConvertionArray = numberbase(DenaryNum,BaseNum); //passes users numbers into the function to be converted 
            bool NonLeading = false;
            for (int i= 0;i<=99;i++) //loops through the array of the converted number
            {
                if (ConvertionArray[i] != 0)
                {
                    NonLeading = true;
                }
                if (NonLeading == true)
                    {
                    Console.Write(ConvertionArray[i]); //prints elemets of the array one by one
                }
            }
            Console.WriteLine("");
        }
    }
}
