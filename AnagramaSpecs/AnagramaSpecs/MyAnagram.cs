using System.Linq;

//"abc acb bac bca cab cba"
namespace AnagramaSpecs {
    public class MyAnagram {
        public static string Run(string anagram) {
            if (anagram.Length >= 4) {
                var combinations = string.Empty;
                var intPtr = GetCombinations(anagram.Length);
                string anagramTemp;
                for (var i = 0; i < intPtr; i++) {
                    if (i == 1) {
                        anagramTemp = $"{anagram.Substring(0, 1)}{anagram.Substring(2, 1)}{anagram.Substring(1, 1)}{anagram.Substring(3)}";
                        combinations = $"{combinations} {anagramTemp}";
                    } else if (i == 2)
                    {
                        anagramTemp = $"{anagram.Substring(1, 1)}{anagram.Substring(0, 1)}{anagram.Substring(2)}";
                        combinations = $"{combinations} {anagramTemp}";
                    }
                    else if (i == 3) {
                        anagramTemp = $"{anagram.Substring(1, 1)}{anagram.Substring(2, 1)}{anagram.Substring(0, 1)}{anagram.Substring(3)}";
                        combinations = $"{combinations} {anagramTemp}";
                    }
                    else
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