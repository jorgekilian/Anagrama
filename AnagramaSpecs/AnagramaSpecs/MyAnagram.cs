using System;
using System.Linq;


namespace AnagramaSpecs {
    public class MyAnagram {
        public static string Run(string anagram) {
            var result = anagram;
            if (anagram.Length >= 3) {
                result = string.Empty;
                var intPtr = GetCombinations(anagram.Length);
                var anagramTemp = anagram;
                for (var i = 0; i < intPtr; i++) {
                    if (i == 1) {
                        anagramTemp = $"{anagram.Substring(0, 1)}{anagram.Substring(2, 1)}{anagram.Substring(1, 1)}{anagram.Substring(3)}";
                    }
                    else if (i == 2) {
                        anagramTemp = $"{anagram.Substring(1, 1)}{anagram.Substring(0, 1)}{anagram.Substring(2)}";
                    }
                    else if (i == 3) {
                        anagramTemp = $"{anagram.Substring(1, 1)}{anagram.Substring(2, 1)}{anagram.Substring(0, 1)}{anagram.Substring(3)}";
                    }
                    else if (i == 4) {
                        anagramTemp = $"{anagram.Substring(2, 1)}{anagram.Substring(0, 1)}{anagram.Substring(1, 1)}{anagram.Substring(3)}";
                    }
                    else if (i == 5) {
                        anagramTemp = $"{anagram.Substring(2, 1)}{anagram.Substring(1, 1)}{anagram.Substring(0, 1)}{anagram.Substring(3)}";
                    }
                    result = $"{result} {anagramTemp}";
                }
            }
            if (anagram.Length == 2)
                result = $"{anagram} {new string(anagram.Reverse().ToArray())}";
            return result.Trim();
        }

        private static int GetCombinations(int number) {
            var ints = Enumerable.Range(1, number);
            return ints.Aggregate((f, s) => f * s);
        }
    }
}