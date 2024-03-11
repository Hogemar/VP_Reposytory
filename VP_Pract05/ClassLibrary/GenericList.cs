using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GenericList<T> where T : IComparable<T>
    {
        private List<T> _list;

        public GenericList()
        {
            _list = new List<T>();
        }


        public void Add(T item) 
        { 
            _list.Add(item);
        }

        public void BubbleSort()
        {
            int n = _list.Count;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)

                    if (_list[j].CompareTo(_list[j + 1]) > 0)
                    {
                        T temp = _list[j];
                        _list[j] = _list[j + 1];
                        _list[j + 1] = temp;
                    }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in _list)
                sb.AppendLine(item.ToString());

            return sb.ToString();
        }

    }
}
