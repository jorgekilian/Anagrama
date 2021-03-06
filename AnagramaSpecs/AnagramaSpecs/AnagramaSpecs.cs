using System.Linq;
using NUnit.Framework;

namespace AnagramaSpecs {
    public class AnagramaSpecs {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void given_an_empty_string_its_anagram_is_an_empty_string() {

            var expected = MyAnagram.Run(string.Empty);

            Assert.AreEqual(expected, string.Empty);
        }

        [Test]
        public void given_a_string_of_length_one_its_anagram_is_a_the_same_string() {

            var expected = MyAnagram.Run("a");

            Assert.AreEqual(expected, "a");
        }

        [Test]
        public void given_a_string_of_length_two_its_anagram_is_the_same_string_and_the_inverse() {

            var expected = MyAnagram.Run("ab");

            Assert.AreEqual(expected, "ab ba");
        }

        [Test]
        public void given_a_specifi_string_of_length_three_its_anagram_is_and_specific_string() {

            var expected = MyAnagram.Run("abc");

            Assert.AreEqual(expected, "abc acb bac bca cab cba");
        }

        [Test]
        public void given_a_string_of_any_length_its_anagram_return_length_factorial_combinations() {
            const string toAnagram = "abcde";

            var expected = MyAnagram.Run(toAnagram);

            Assert.AreEqual(expected.Split().Length, GetCombinations(toAnagram.Length));
        }

        [Test]
        public void given_a_string_its_anagram_the_second_combination_is_the_string_changin_second_and_third_position() {
            const string toAnagram = "abcde";

            var expected = MyAnagram.Run(toAnagram);

            Assert.AreEqual(expected.Split()[1], "acbde");
        }

        [Test]
        public void given_a_string_its_anagram_the_third_combination_is_the_string_changin_first_and_second_position() {
            const string toAnagram = "abcde";

            var expected = MyAnagram.Run(toAnagram);

            Assert.AreEqual(expected.Split()[2], "bacde");
        }

        [Test]
        public void given_a_string_its_anagram_the_fourth_combination_is_the_string_changin_first_to_third_position_and_second_to_first_and_third_to_second() {
            const string toAnagram = "abcde";

            var expected = MyAnagram.Run(toAnagram);

            Assert.AreEqual(expected.Split()[3], "bcade");
        }

        [Test]
        public void given_a_string_its_anagram_the_fith_combination_is_the_string_changin_first_to_second_position_and_second_to_third_and_third_to_first() {
            const string toAnagram = "abcde";

            var expected = MyAnagram.Run(toAnagram);

            Assert.AreEqual(expected.Split()[4], "cabde");
        }

        [Test]
        public void given_a_string_its_anagram_the_sixth_combination_is_the_string_changin_first_to_third_position_and_third_to_first() {
            const string toAnagram = "abcde";

            var expected = MyAnagram.Run(toAnagram);

            Assert.AreEqual(expected.Split()[5], "cbade");
        }

        private int GetCombinations(int number) {
            var ints = Enumerable.Range(1, number);
            return ints.Aggregate((f, s) => f * s);
        }
    }
}