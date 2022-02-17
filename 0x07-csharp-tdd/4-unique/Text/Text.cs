using System;

namespace Text
{
    /// <summary> Stringly Bingly </summary>
    public class Str
    {
        /// <summary> Checks For Uniques </summary>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;    
            for (int x = 0; x < s.Length; x++)
            {
                int counter = 0;
                foreach (char g in s)
                {
                    if (g == s[x])
                        counter++;
                    if (counter > 1)
                        break;
                }
                if (counter == 1)
                    return x;
            }
            return -1;
        }
    }
}
