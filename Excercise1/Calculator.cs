using System;

namespace Excercise1
{
    public class Calculator
    {
        //Function computes the problem in the excercise
        public double ResolveProblem()
        {
            double result = 0D;

            //Resolve the Sigma, where k goes from 1 to 10^6
            for (double k = 1D; k <= (int)(Math.Pow(10D, 6D)); k++)
            {
                result =+ this.ResolveSequence(k);
            }
            result = result * 4D;

            return result;
        }

        //This functions resolves the sequence which will be added
        public double ResolveSequence(double k)
        {
            return Math.Pow((-1), ((double)k + 1)) / (2 * (double)k - 1);
        }

    }
}
