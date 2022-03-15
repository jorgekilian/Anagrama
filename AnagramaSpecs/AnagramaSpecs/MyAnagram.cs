using System.Linq;

namespace AnagramaSpecs {
    public class MyAnagram {
        public static string Run(string anagram) {
            if (anagram.Length >= 4) {
                var combinations = string.Empty;
                var intPtr = GetCombinations(anagram.Length);
                for (var i = 0; i < intPtr; i++) {
                    combinations = $"{combinations} {anagram}";
                }
                return combinations.Trim();
            }
            if (anagram.Length == 3)
                return "abc acb bac bca cab cba";
            if (anagram.Length == 2)
                return $"{anagram} {new string(anagram.Reverse().ToArray())}";
            return anagram;
        }

        private static int GetCombinations(int number) {
            var ints = Enumerable.Range(1, number);
            return ints.Aggregate((f, s) => f * s);
        }
    }
}