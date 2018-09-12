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
            int[] operated = new int[n];
            for(int i = 0; i < n; i++)
            {
                operated[i] = op(numbers[i]);
            }
            return operated;            
        }
    }
}
