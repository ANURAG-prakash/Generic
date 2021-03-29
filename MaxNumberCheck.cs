using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumberProject
{
    public class MaxNumberCheck
    {


        public static int MaximumIntergerNumber(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            if (FirstNumber.CompareTo(SecondNumber) > 0 && FirstNumber.CompareTo(ThirdNumber) > 0)
            {
                return FirstNumber;
            }
            if (SecondNumber.CompareTo(FirstNumber) > 0 && SecondNumber.CompareTo(ThirdNumber) > 0)
            {
                return SecondNumber;
            }
            if (ThirdNumber.CompareTo(FirstNumber) > 0 && ThirdNumber.CompareTo(SecondNumber) > 0)
            {
                return ThirdNumber;
            }
            throw new Exception("All Number Are Equal");
        }
        public static double MaximumFloatNumber(double FirstNumber, double SecondNumber, double ThirdNumber)
        {
            if (FirstNumber.CompareTo(SecondNumber) > 0 && FirstNumber.CompareTo(ThirdNumber) > 0)
            {
                return FirstNumber;
            }
            if (SecondNumber.CompareTo(FirstNumber) > 0 && SecondNumber.CompareTo(ThirdNumber) > 0)
            {
                return SecondNumber;
            }
            if (ThirdNumber.CompareTo(FirstNumber) > 0 && ThirdNumber.CompareTo(SecondNumber) > 0)
            {
                return ThirdNumber;
            }
            throw new Exception("All Number Are Equal");
        }
        public static string MaximumStringValue(string First,string Second,string Third)
        {
            if (First.CompareTo(Second)>0 && First.CompareTo(Third)>0 || First.CompareTo(Second)>=0 && First.CompareTo(Third)>0 || First.CompareTo(Second)>0 && First.CompareTo(Third)>=0)
            {
                return First;
            }
            if(Second.CompareTo(First)>0 && Second.CompareTo(Third)>0 || Second.CompareTo(First) >= 0 && Second.CompareTo(Third) > 0 || Second.CompareTo(First) > 0 && Second.CompareTo(Third) >= 0)
            {
                return Second;
            }
            if(Third.CompareTo(First)>0 && Third.CompareTo(Second)>0 || Third.CompareTo(First) >= 0 && Third.CompareTo(Second) > 0 || Third.CompareTo(First) > 0 && Third.CompareTo(Second) >= 0)
            { 
                return Third;
            }
            throw new Exception("All String Are Equal");
        }
    }
}
