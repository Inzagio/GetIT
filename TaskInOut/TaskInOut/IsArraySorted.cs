using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInOut
{
    class IsArraySorted
    {
        public static bool isArraySorted(int[] intArray)
        {
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i - 1] > intArray[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
