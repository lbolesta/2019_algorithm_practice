using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var paren = new GenerateBalancedParen();
            var result = paren.GenerateParenthesis(2);
            foreach(var r in result)
            {
                Console.WriteLine(r);
            }

            var str = "aabbccdddfff";
            var freq = GetFrequencyOfCharsInString(str);
            foreach(var f in freq)
            {
                Console.WriteLine(f.Key + " " + f.Value);
            }
            

        }

        private new static Dictionary<char, int> GetFrequencyOfCharsInString(string str)
        {
            var result = new Dictionary<char, int>();
            var dict = new Dictionary<char, int>();

            var charArray = str.ToCharArray();
            foreach (var c in charArray)
            {
                if (dict.ContainsKey(c)) { dict[c] += 1; }
                else { dict.Add(c, 1); }
            }

            var max = dict.Values.Max();

            var res = dict.Where(x => x.Value == dict.Values.Max())
                .Select(x => new { key = x.Key, value = x.Value });
            var ret = res.ToDictionary(x => x.key);
            foreach (var r in ret)
                result.Add(r.Key, r.Value.value);
            return result;


        }
    }
}
