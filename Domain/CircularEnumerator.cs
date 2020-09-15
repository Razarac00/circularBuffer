using System;
using System.Collections;

namespace Domain
{
    public class CircularEnumerator<T> : IEnumerator
    {
        private T[] _array { get; set; }
        public CircularEnumerator(T t, Array array)
        {
            throw new NotImplementedException();

        }

        public bool MoveNext()
        {
            throw new NotImplementedException();

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current 
        {
            get 
            {
                throw new NotImplementedException();
            }
        }
    }
}