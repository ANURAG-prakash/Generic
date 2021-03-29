using System;

namespace FindMaximumNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");
            int output = MaxNumberCheck.MaximumIntergerNumber(11, 22, 33);
            double number = MaxNumberCheck.MaximumFloatNumber(2.2, 3.3, 4.4);
            Console.WriteLine(output);
            Console.WriteLine(number);
        }
    }
   
}
