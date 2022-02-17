using System;

namespace Text
{
    /// <summary> Str public class </summary>
    public class Str
    {
        /// <summary> Palindromes </summary>
        public static bool IsPalindrome(string s)
        {
            int front = 0;
            int back = s.Length - 1;
            string statement = s.ToLower();
            if (s.Length < 2)
                return true;
            while (statement[front] < 'a' || statement[front] > 'z')
                front++;
            while (statement[back] < 'a' || statement[back] > 'z')
                back--;
            while (statement[front] == statement[back])
            {
                front++;
                back--;
                while (statement[front] < 'a' || statement[front] > 'z')
                    front++;
                while (statement[back] < 'a' || statement[back] > 'z')
                    back--;
                if (front >= back)
                return true;
            }
            return false;
        }
    }
}
