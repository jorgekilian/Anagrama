using System;
using NUnit.Framework;

namespace AnagramaSpecs {
    public class AnagramaSpecs {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void given_an_empty_string_its_anagram_is_an_empty_string() {

            var expected = MyAnagram.Run(string.Empty);

            Assert.Equals(expected, string.Empty);
        }

    }

    public class MyAnagram {
        public static string Run(string empty) {
            return string.Empty;
        }
    }
}