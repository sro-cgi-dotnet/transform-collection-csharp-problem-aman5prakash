using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate int operation(int numbers);
    public static class Transform 
    {
        
        public static int[] Map(this int[] numbers, operation op)
        {
            int n = numbers.Length;

            //Making an arrar of same length of input array
            int[] operated = new int[n];

            // apply lambda expression to each element of input array
            for(int i = 0; i < n; i++)
            {
                operated[i] = op(numbers[i]);
            }
            return operated;            
        }
    }
}
