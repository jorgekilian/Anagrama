using System.Linq;


namespace AnagramaSpecs {
    public class MyAnagram {
        public static string Run(string anagram) {
            var result = anagram;
            if (anagram.Length >= 3) {
                result = string.Empty;
                var numberOfCombinations = GetCombinations(anagram.Length);
                var newCombination = anagram;

                for (var i = 0; i < numberOfCombinations; i++) {
                    var pos = i % numberOfCombinations;
                    if (pos == 1) {
                        newCombination = $"{anagram.Substring(0, 1)}{anagram.Substring(2, 1)}{anagram.Substring(1, 1)}{anagram.Substring(3)}";
                    }
                    else if (pos == 2) {
                        newCombination = $"{anagram.Substring(1, 1)}{anagram.Substring(0, 1)}{anagram.Substring(2)}";
                    }
                    else if (pos == 3) {
                        newCombination = $"{anagram.Substring(1, 1)}{anagram.Substring(2, 1)}{anagram.Substring(0, 1)}{anagram.Substring(3)}";
                    }
                    else if (pos == 4) {
                        newCombination = $"{anagram.Substring(2, 1)}{anagram.Substring(0, 1)}{anagram.Substring(1, 1)}{anagram.Substring(3)}";
                    }
                    else if (pos == 5) {
                        newCombination = $"{anagram.Substring(2, 1)}{anagram.Substring(1, 1)}{anagram.Substring(0, 1)}{anagram.Substring(3)}";
                    }
                    result = $"{result} {newCombination}";
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