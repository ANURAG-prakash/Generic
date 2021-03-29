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
            string value = MaxNumberCheck.MaximumStringValue("11", "22", "33");
            Console.WriteLine(output);
            Console.WriteLine(number);
            Console.WriteLine(value);
            int[] intArray = { 11, 22, 33 };
            double[] doubleArray = { 2.2, 3.3,4.4 };
            string[] stringArray = { "22", "33", "44" };
            GenericMaximum<int> intgeneric = new GenericMaximum<int>(intArray);
            intgeneric.PrintMaxValue();
            GenericMaximum<double> doublegeneric = new GenericMaximum<double>(doubleArray);
            doublegeneric.PrintMaxValue();
            GenericMaximum<string> stringgeneric = new GenericMaximum<string>(stringArray);
            stringgeneric.PrintMaxValue();
        }
    }
   
}
