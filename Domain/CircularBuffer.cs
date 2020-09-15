using System;
using System.Collections;

namespace Domain
{
    public class CircularBuffer
    {
        public CircularBuffer()
        {
            throw new NotImplementedException();
        }

        public CircularBuffer(int size)
        {
            throw new NotImplementedException();
        }

        public void AddtoBuffer(char x)
        {
            throw new NotImplementedException();
        }

        public char ReadfromBuffer()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetIterator() // to implement foreach, we need a public definition of GetEnumerator
        {
            throw new System.NotImplementedException();
        }
        // We need a class that implements the IEnumerator interface, which means implementing IEnumerator.Current, MoveNext(), Reset()
    }
}
