using System.Collections;

namespace DynamicArrayNS
{
	public class DynamicArray<T> : IEnumerable<T>
	{
		///*  СВОЙСТВА  */// 
		
		// Элементы массива
		private T[] _elements;

		// Количество элементов
		public int Count { get; private set; }

		// Ёмкость массива
		public int Capacity { get => _elements.Length; }

		// Шаг увеличения ёмкости
		private int _capacityStep;
		public int CapacityStep
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

		public DynamicArray(uint capacity = 20)
		{
			_elements = new T[capacity];
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
				IncreaseCapacity(elements.Count());

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
		public void IncreaseCapacity(int n)
		{
			if (n == 0) return;

			T[] newElements = new T[Capacity + n];

			for (int i = 0; i < Count; i++)
				newElements[i] = _elements[i];

			_elements = newElements;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return new DAEnumerator<T>(_elements, Count);
		}

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

		public int IndexOf(T value, int startPosition, int endPosition)
		{
            if (startPosition < 0 || startPosition >= endPosition)
                throw new Exception("Invalid start position!");

            if (endPosition <= startPosition || endPosition > Count)
                throw new Exception("Invalid end position!");

			for (int i = startPosition; i < endPosition; i++)
				if (_elements[i].Equals(value))
					return i;

			return -1;
		}
	}
}

