using System.Collections;

namespace DynamicArrayNS
{
    class DAEnumerator<T> : IEnumerator<T>
    {
        private T[] _elements; // Элементы массива
        private int _count; // Доступное количество элементов
        private int position = -1;

        public DAEnumerator(T[] elements, int count)
        {
            this._elements = elements;
            this._count = count;
        }

        // Свойство получения нынешнего элемента
        public T Current 
        {
            get
            {
                if (position == -1 || position >= _count) throw new Exception("Invalid enumeration position!");

                return _elements[position];
            }
        }

        object IEnumerator.Current => this.Current;

        public bool MoveNext()
        {
            return (++position < _count);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }
    }
}
