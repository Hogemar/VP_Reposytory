using System.Collections;

namespace DinamicArrayNS
{
	public class DinamicArray<T> : IEnumerable<T>
	{
		///*  СВОЙСТВА  */// 
		
		// Элементы массива
		private T[] _elements;

		// Количество элементов
		public int Count { get; private set; }

		// Ёмкость массива
		public uint Capacity { get; private set; }

		// Шаг увеличения ёмкости
		private uint _capacityStep;
		public uint CapacityStep
		{
			get
			{
				return _capacityStep;
			}

			set
			{
				if (value <= 0) throw new Exception("Capacity step must be positive number!");

				_capacityStep = value;
			}
		}

		///*  КОНСТРУКТОРЫ  */// 

		//public DinamicArray()
		//{
		//    Capacity = 20;
		//    _elements = new T[Capacity];
		//}

		public DinamicArray(uint capacity = 20)
		{
			this.Capacity = capacity;
			_elements = new T[Capacity];
		}

		///*  МЕТОДЫ  */// 

		// Вставка элемент в конец массива
		public void Add(T element)
		{
			if (Count == Capacity)
				IncreaseCapacity(_capacityStep);

			_elements[Count++] = element;
		}

		// Добавление коллекции в конец массива
		public void Add(IEnumerable<T> elements)
		{
			if (Count + elements.Count() >= Capacity)
				IncreaseCapacity(Convert.ToUInt32(elements.Count()));

			for (int i = 0; i < elements.Count(); i++)
				_elements[Count+i] = elements.ElementAt(i);

			Count += elements.Count();
		}

		// Вставка элемента на указанную позицию
		public void Insert(T element, int position)
		{
			if (position < 0 || position >= Count) throw new Exception("Invalid insert position!");

			if(Count == Capacity)
				IncreaseCapacity(_capacityStep);

			for (int i = Count; i > position; i--)
				_elements[i] = _elements[i-1];

			_elements[position] = element;
			Count++;
		}

		// Удаление элемента с указанной позиции
		public void RemoveAt(int position)
		{
			if (position < 0 || position >= Count) throw new Exception("Invalid remove position!");

			for (int i = position; i < Count; i++)
				_elements[i] = _elements[i+1];

			Count--;
		}

		// Увеличение ёмкости на n элементов
		public void IncreaseCapacity(uint n)
		{
			if (n == 0) return;

			Capacity += n;
			T[] newElements = new T[Capacity];

			for (uint i = 0; i < Count; i++)
				newElements[i] = _elements[i];

			_elements = newElements;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return new DAEnumerator<T>(_elements, Count);
		}

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}
}
