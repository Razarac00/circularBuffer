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
        [InlineData(1)]
        [InlineData(1000)]
        [InlineData(1000000)]
        public void TestCircularBufferWithGoodSizes(int data)
        {
            // arrange
            CircularBuffer<int> c = new CircularBuffer<int>(data);

            // act
            int realSize = c.size;

            // assert
            Assert.Equal(realSize, data);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(1000001)]
        [InlineData(Int32.MinValue)]
        [InlineData(Int32.MaxValue)]
        public void TestCircularBufferWithBadSizes(int data)
        {

            // assert
            Assert.Throws<IndexOutOfRangeException>(() => new CircularBuffer<int>(data));
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
            CircularBuffer<char> c = new CircularBuffer<char>(2);

            // act
            c.AddtoBuffer('a');
            c.AddtoBuffer('b');
            c.AddtoBuffer('c');

            // assert
            Assert.False(Array.Exists<char>(c.buffer, element => element == 'a'));
            Assert.True(Array.Exists<char>(c.buffer, element => element == 'b'));
            Assert.True(Array.Exists<char>(c.buffer, element => element == 'c'));
        }

        [Fact]
        public void TestReadEmptyBuffer()
        {
            // arrange
            CircularBuffer<char> c = new CircularBuffer<char>(2);

            // act
            //char expected = null;

            // assert
            Assert.Throws<IndexOutOfRangeException>(() => c.ReadfromBuffer());
        }

        [Fact]
        public void TestReadfromBuffer()
        {
            // arrange
            CircularBuffer<char> c = new CircularBuffer<char>(2);

            // act
            c.AddtoBuffer('a');
            c.AddtoBuffer('b');
            char expected = 'a';

            // assert
            Assert.Equal(c.ReadfromBuffer(), expected);
        }

        [Fact]
        public void TestRepeatableReadfromBuffer()
        {
            // arrange
            CircularBuffer<char> c = new CircularBuffer<char>(2);

            // act
            c.AddtoBuffer('a');
            c.AddtoBuffer('b');
            char expected = 'a';

            // assert
            Assert.Equal(c.ReadfromBuffer(), expected);
            Assert.Equal(c.ReadfromBuffer(), expected);
        }

        [Fact]
        public void TestRepeatableReadAfterAdding()
        {
            // arrange
            CircularBuffer<char> c = new CircularBuffer<char>(3);

            // act
            c.AddtoBuffer('a');
            c.AddtoBuffer('b');
            char expected = 'a';
            char firstResult = c.ReadfromBuffer();
            c.AddtoBuffer('c');


            // assert
            Assert.Equal(firstResult, expected);
            Assert.Equal(c.ReadfromBuffer(), expected);
        }

        [Fact]
        public void TestGetIterator()
        {
            // arrange
            CircularBuffer<char> c = new CircularBuffer<char>(3);
            char[] actualArray = new char[] { };
            int counter = 0;

            // act
            c.AddtoBuffer('a');
            c.AddtoBuffer('b');
            char expected1 = 'a';
            char expected2 = 'b';

            foreach (char item in c)
            {
                actualArray[counter] = item;
                counter++;
            }

            // assert
            Assert.Equal(actualArray[0], expected1);
            Assert.Equal(actualArray[1], expected2);
        }
    }
}
