using System;

namespace Text
{
    /// <summary> Stringle BINGLE </summary>
    public class Str
    {
        /// <summary> Wednesday </summary>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0) 
                 return 0; 
            int hump_days = 1;
            foreach (char x in s)
            {
                if (Char.IsUpper(x))
                    hump_days++;
            }
            return hump_days;
        }
    }
}