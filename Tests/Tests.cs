using System;
using MiscLib;
using Xunit;

namespace Tests {
    public class MiscLibTests {

        [Fact]
        public void CalcRectArea_test () {
            GroupOneFunctions g1 = new GroupOneFunctions ();

            Assert.Equal (10, g1.CalcRectArea (2, 5));
            Assert.Equal (25, g1.CalcRectArea (5, 5));
            Assert.Equal (4, g1.CalcRectArea (2, 2));
            Assert.Equal (500, g1.CalcRectArea (2, 250));
        }

        [Fact]
        public void IsFactorialNum_test () {
            GroupOneFunctions g1 = new GroupOneFunctions ();
            Assert.True ( g1.IsFactiorialNum (120));
            Assert.True ( g1.IsFactiorialNum (1));
            Assert.False (g1.IsFactiorialNum (40));
            Assert.False ( g1.IsFactiorialNum (60));
        }

        [Fact]
        public void CelciusToFarenheit_test () {
            GroupOneFunctions g1 = new GroupOneFunctions ();
            Assert.Equal (248, g1.CelciusToFarenheit (120));
            Assert.Equal (106, g1.CelciusToFarenheit (41));
            Assert.Equal (124, g1.CelciusToFarenheit (51));
            Assert.Equal (127, g1.CelciusToFarenheit (53));

        }

        [Theory]
        [InlineData (true, "racecar")]
        [InlineData (true, "rotator")]
        [InlineData (true, "1bob1")]
        [InlineData (false, "david")]

        public void IsPalindrome_test (bool expected, string test) {
            GroupOneFunctions g1 = new GroupOneFunctions ();
            Assert.Equal (expected, g1.IsPalindrome (test));
        }

        [Theory]
        [InlineData ("abcd3fg", "abcdefg", 'e', '3')]
        [InlineData ("bump", "bamp", 'a', 'u')]
        [InlineData ("aaaaaaa", "bbbbbbb", 'b', 'a')]
        public void StringReplace_test (string expected, string original, char check, char replace) {
            GroupOneFunctions g1 = new GroupOneFunctions ();
            Assert.Equal (expected, g1.StringReplace (original, check, replace));
        }

        [Theory]
        [InlineData (3, "ababa", 'a')]
        [InlineData (4, "rinky dinky binky i", 'i')]
        [InlineData (5, "s2t2a2k2a2", '2')]

        public void CharCount_test (int expected, string word, char choice) {
            GroupOneFunctions g1 = new GroupOneFunctions ();
            Assert.Equal (expected, g1.CharCount(word, choice));

        }
    }
}