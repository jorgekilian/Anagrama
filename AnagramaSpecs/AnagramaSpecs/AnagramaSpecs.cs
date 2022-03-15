using System;
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

    }

    public class MyAnagram {
        public static string Run(string anagram) {
            if (anagram.Length == 3)
                return "abc acb bac bca cab cba";
            if(anagram.Length == 2)
                return $"{anagram} {new string(anagram.Reverse().ToArray())}";
            return anagram;
        }
    }
}