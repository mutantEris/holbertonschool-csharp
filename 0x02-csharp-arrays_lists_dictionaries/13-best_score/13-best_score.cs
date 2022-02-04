using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> score = new KeyValuePair<string, int>("None", -1);
        foreach (KeyValuePair<string, int> x in myList)
        {
            if (x.Value > score.Value)
                score = x;
        }
        return score.Key;
    }
}