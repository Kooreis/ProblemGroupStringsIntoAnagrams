```C#
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "cat", "dog", "tac", "god", "good", "act" };
        var groupedAnagrams = GroupAnagrams(words);

        foreach (var group in groupedAnagrams)
        {
            Console.WriteLine(string.Join(", ", group));
        }
    }

    static List<List<string>> GroupAnagrams(string[] strs)
    {
        if (strs == null || strs.Length == 0) return new List<List<string>>();

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            char[] ca = s.ToCharArray();
            Array.Sort(ca);
            string keyStr = new string(ca);

            if (!map.ContainsKey(keyStr))
                map.Add(keyStr, new List<string>());

            map[keyStr].Add(s);
        }

        return new List<List<string>>(map.Values);
    }
}
```