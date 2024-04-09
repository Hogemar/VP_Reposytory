namespace LinqExtensionsLogic
{

	public static class MyExtensions
	{

		// Проверка, удовлетворяют ли все элементы условию (предикату)
		public static bool MyAll<TSource>
			(
			this IEnumerable<TSource> source,
			Func<TSource, bool> predicate
			)
		{
			foreach (var item in source)
				if (predicate(item) == false)
					return false;

			return true;
		}

		// Возвращает коллекцию – пересечение двух коллекций по ключам
		public static IEnumerable<TSource> MyIntersect<TSource, TKey>
			(
			this IEnumerable<TSource> first,
			IEnumerable<TSource> second,
			Func<TSource, TKey> keyExtractor
			)
		{
			var result = new List<TSource>();

			foreach (var item1 in first)
				foreach (var item2 in second)
                    if (keyExtractor(item2).Equals(keyExtractor(item1)))
                        result.Add(item1);

			return result;
		}

		// Применяет функцию ко всем элементам коллекции и возвращает коллекцию с результатами
		public static IEnumerable<TResult> MyDoThing<TSource, TResult>
			(
			this IEnumerable<TSource> source,
			Func<TSource, TResult> thing
			)
		{
			var result = new List<TResult>();

			foreach (var item in source)
				result.Add(thing(item));

			return result;
		}

		// Исключает повторяющиеся элементы с одним ключом
		public static IEnumerable<TSource> MyDistinct<TSource, Tkey>
			(
			this IEnumerable<TSource> source,
			Func<TSource, Tkey> keyExtractor
			)
		{
			var result = new List<TSource>();

			foreach (var item1 in source)
			{
				bool isAdded = false;
				foreach (var item2 in result)
					if (keyExtractor(item2).Equals(keyExtractor(item1)))
						isAdded = true;
				if (!isAdded)
					result.Add(item1);
			}
			return result;
		}
		
		// Возвращает словарь из переданной коллекции
		public static Dictionary<TKey, TValue> MyToDictionary<TValue, TKey> 
			(
			this IEnumerable<TValue> source,
			Func<TValue, TKey> keyExtractor
			) where TKey : notnull
		{
			var result = new Dictionary<TKey, TValue>();

			foreach (var item in source)
				if (result.TryAdd(keyExtractor(item), item) == false)
					throw new Exception($"Key '{keyExtractor(item)}' is not unique!");

			return result;
		}

	}
	
}
