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
    }
}
