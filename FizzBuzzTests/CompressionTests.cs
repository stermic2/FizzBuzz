using System.Collections.Generic;
using System.Threading.Tasks;
using FizzBuzz;
using Shouldly;
using Xunit;

namespace FizzBuzzTests
{
    public class CompressionTests
    {
        [Fact]
        public async Task charactersCompress()
        {
            //arrange
            string testString = "019fz\nb";
            ulong testLong = 0;
            //act
            foreach (var s in testString)
                testLong.Shift4BitsThenAdd(s);
            //assert
            testLong.ShouldBeEquivalentTo((ulong)169463485);
        }
        
        [Fact]
        public async Task ulongDecompresses()
        {
            //arrange
            string testString = "019fz\nb";
            ulong testLong = 0;
            foreach (var s in testString)
                testLong.Shift4BitsThenAdd(s);
            //act
            testString = testLong.DecompressUlong();
            //assert
            testString.ShouldBe("019FizzFizz Buzz\nBuzz");
        }
        
        [Fact]
        public async Task FizzAndBuzzCanBeSubstituted()
        {
            //arrange
            string testString = "019fz\nb";
            ulong testLong = 0;
            foreach (var s in testString)
                testLong.Shift4BitsThenAdd(s);
            //act
            CompressionExtensions.modThree = "Fizzy";
            CompressionExtensions.modFive = "Buzzy";
            testString = testLong.DecompressUlong();
            //assert
            testString.ShouldBe("019FizzyFizzy Buzzy\nBuzzy");
        }
    }
}