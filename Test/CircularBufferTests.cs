using System;
using Xunit;
using Domain;

namespace Test
{
    public class CircularBufferTests
    {
        [Fact]
        public void TestCircularBufferDefault()
        {
            // arrange
            CircularBuffer<char> c = new CircularBuffer<char>();

            // act
            bool is7= (7 == c.size);

            // assert
            Assert.True(is7);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(999)]
        [InlineData(1000)]
        [InlineData(1001)]
        [InlineData(Int32.MaxValue)]
        [InlineData(Int32.MinValue)]
        public void TestCircularBufferWithSizes(int data)
        {
            // arrange
            CircularBuffer<int> c = new CircularBuffer<int>(data);

            // act
            int realSize = c.size;

            // assert
            Assert.Equal(realSize, data);
        }

        [Theory]
        [InlineData('0')]
        [InlineData('1')]
        [InlineData('-')]
        [InlineData('z')]
        [InlineData('A')]
        [InlineData('#')]
        public void TestAddtoBuffer(char x)
        {
            // arrange
            CircularBuffer<char> c = new CircularBuffer<char>();

            // act
            c.AddtoBuffer(x);

            // assert
            Assert.True(Array.Exists<char>(c.buffer, element => element == x));
        }

        [Fact]
        public void TestLoopBackAfterAdd()
        {
            // arrange
            
            // act
            
            // assert
        }

        [Fact]
        public void TestReadEmptyBuffer()
        {
            // arrange
            
            // act
            
            // assert
        }

        [Fact]
        public void TestReadfromBuffer()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void TestRepeatableReadfromBuffer()
        {
            // arrange
            
            // act
            
            // assert
        }

        [Fact]
        public void TestRepeatableReadAfterAdding()
        {
            // arrange
            
            // act
            
            // assert
        }

        [Fact]
        public void TestGetIterator()
        {
            // arrange
            
            // act
            
            // assert
            throw new System.NotImplementedException();
        }
    }
}
