using System.Collections;
using System;

namespace MyCollection
{
    public class MyElemCollection : IList, ICollection, ICloneable
    {
        private object[] collection;
        private int _size;
        private int count;
        public MyElemCollection(int size)
        {
            _size = size;
            count = 0;
            collection = new object[_size];

            // цикл для теста
            /*for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = 0 + i;
            }*/
        }

        public int GetLenght()
        {
            return collection.Length;
        }

        public object this[int index]
        {
            get
            {
                return collection[index];
            }

            set
            {
                collection[index] = value;
            }
        }
        public int Add(object value)
        {
            if (count < collection.Length)
            {
                collection[count] = value;
                count++;

                return (count - 1);
            }

            return -1;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (collection[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            if ((count + 1 <= collection.Length) && (index < count) && (index >= 0))
            {
                count++;

                for (int i = count - 1; i > index; i--)
                {
                    collection[i] = collection[i - 1];
                }
                collection[index] = value;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < count))
            {
                for (int i = index; i < count - 1; i++)
                {
                    collection[i] = collection[i + 1];
                }
                count--;
            }
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < count; i++)
            {
                array.SetValue(collection[i], index++);
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this;
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
