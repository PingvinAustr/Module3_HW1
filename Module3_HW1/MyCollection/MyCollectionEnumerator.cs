using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW1
{
    public class MyCollectionEnumerator<T> : IEnumerator<T>
    {
        private T[] _items;
        private int _position = -1;
        public MyCollectionEnumerator(T[] items)
        {
            _items = items;
        }

        public T Current
        {
            get
            {
                if (_position == -1 || _position >= _items.Length)
                {
                    throw new InvalidOperationException();
                }

                return _items[_position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (_position < _items.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
        }
    }
}
