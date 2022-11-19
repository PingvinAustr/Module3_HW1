using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW1
{
    public class MyCollection<T> : IEnumerable<T>
    {
        private T[] _collectionItems = new T[5];

        public int Count { get; private set; }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return _collectionItems[i];
            }

            set
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                _collectionItems[i] = value;
            }
        }

        public void Add(T value)
        {
            if (Count >= _collectionItems.Length)
            {
                Array.Resize<T>(
                    ref _collectionItems,
                    _collectionItems.Length * 2);
            }

            _collectionItems[Count] = value;
            Count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> itemsToAdd)
        {
           foreach (T item in itemsToAdd)
           {
                Add(item);
           }
        }

        // Removes the first occurrence of specific object from the Collection
        public void Remove<K>(K item)
         where K : IComparable<T>
        {
            for (int i = 0; i < Count; i++)
            {
                int result = item.CompareTo(_collectionItems[i]);
                if (result == 0)
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                var b = new T[_collectionItems.Length - 1];
                Array.Copy(
                    _collectionItems,
                    0,
                    b,
                    0,
                    index);
                Array.Copy(
                    _collectionItems,
                    index + 1,
                    b,
                    index,
                    _collectionItems.Length - index - 1);
                _collectionItems = b;
                Count--;
            }
        }

        public void Sort()
        {
            int len = _collectionItems.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    int result = Comparer<T>.Default.Compare(
                        _collectionItems[j],
                        _collectionItems[j + 1]);
                    if (result < 0)
                    {
                        Swap<T>(
                            ref _collectionItems[j],
                            ref _collectionItems[j + 1]);
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyCollectionEnumerator<T>(_collectionItems);
        }

        // To swap items while sorting
        private static void Swap<K>(ref K e1, ref K e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
