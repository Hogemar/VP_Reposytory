namespace DAExpansion
{
    public static class DAExpansions
    {
        public static void Filter<T>(this DinamicArrayNS.DinamicArray<T> dinamicArray, Func<T, bool> elementRemains)
        {
            for (int i = 0; i < dinamicArray.Count; i++)
                if (elementRemains(dinamicArray.ElementAt(i)) == false)
                    dinamicArray.RemoveAt(i);
        }

        public static void Sort<T>(this DinamicArrayNS.DinamicArray<T> dinamicArray, Func<T, T, int> compare)
        {
            for (int i = 0; i < dinamicArray.Count - 1; i++)
                for (int j = 0; j < dinamicArray.Count - i - 1; j++)

                    if (compare(dinamicArray.ElementAt(j), dinamicArray.ElementAt(j+1)) > 0)
                    {
                        T temp = dinamicArray.ElementAt(j + 1);
                        dinamicArray.RemoveAt(j+1);
                        dinamicArray.Insert(temp, j);
                    }
            
        }
    }
}
