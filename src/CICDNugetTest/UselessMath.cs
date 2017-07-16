using System;

namespace CICDNugetTest
{
    public static class UselessMath
    {
        /// <summary>
        /// Returns the sum of the parameters.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double Sum(params double[] input)
        {
            if (input == null)
                throw new ArgumentNullException("input");

            double sum = 0;
            for(int i = 0; i < input.Length; i++)
                sum += input[i];

            return sum;
        }

        /// <summary>
        /// Returns the average of the parameters.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double Average(params double[] input)
        {
            if (input == null)
                throw new ArgumentNullException("input");

            if (input.Length == 0)
                return 0;

            return Sum(input) / input.Length;
        }
    }
}