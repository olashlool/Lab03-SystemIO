using System;
using Xunit;
using Lab03_SystemIO;


namespace xUnitTest
{
    public class UnitTest1
    {
        // Challenge 1
        [Theory]
        [InlineData(new[] { "1", "2", "3", "4", "6" }, 6)]
        [InlineData(new[] { "3", "4", "5" }, 60)]
        [InlineData(new[] { "7", "8" }, 0)]
        [InlineData(new[] { "-6", "-4", "-3" }, -72)]
        [InlineData(new[] { "ola", "shlool", "-3" }, -3)]

        public void multiplies_3_nums_in_array_only(string[] arr, int expected)
        {
            //Act
            int result = Program.GetProudct(arr);

            //Assert
            Assert.Equal(result, expected);
        }
        // Challenge 2
        [Theory]
        [InlineData(new int[] { 2, 6, 7 }, 5)]
        [InlineData(new int[] { 4, 8, 15, 16 }, 10)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]

        public void Average_element_in_array(int[] input, int expected)
        {
            int result = Program.AverageNumber(input);
            Assert.Equal(expected, result);
        }
        // Challenge 4

        [Theory]
        [InlineData(new[] { 1, 1, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 3 }, 1)]
        public void finds_most_freq(int[] arr, int expected)
        {
            //Act
            int result = Program.MostCommonNumber(arr);

            //Assert
            Assert.Equal(result, expected);
        }
        // Challenge 5

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new[] { -2, -1, 0, 1 }, 1)]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 1)]
        public void finds_max(int[] arr, int expected)
        {
            //Act
            int result = Program.GetMaxNumber(arr);

            //Assert
            Assert.Equal(result, expected);
        }
        // Challenge 9
        [Theory]
            [InlineData( "ola shlool", new string[] { "ola: 3, ", "shlool: 6, " })]
            [InlineData("nothing is IMPOSSIBLE!", new string[] { "nothing: 7, ", "is: 2, ", "IMPOSSIBLE!: 11, " })]
        public void HandlesSentencesWithDifferentSymbols(string input, string[] expected)
        {
            string[] result = Program.wordWithLength(input);
            Assert.Equal(expected, result);
        }
    }
}
