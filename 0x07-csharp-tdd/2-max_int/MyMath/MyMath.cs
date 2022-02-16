using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary> Operations public class</summary>
    public class Operations
    {
        /// <summary> The maximum number</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null)
                return 0;
            if (nums.Count == 0)
                return 0;
            nums.Sort();
            return nums.Last(); 
        }
    }
}
