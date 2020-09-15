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
            CircularBuffer c = new CircularBuffer();

            // act


            // assert
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
            CircularBuffer c = new CircularBuffer(data);

            // act


            // assert
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
            CircularBuffer c = new CircularBuffer();

            // act
            c.AddtoBuffer(x);

            // assert
            
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
