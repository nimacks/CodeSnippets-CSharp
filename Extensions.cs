 public static class Extensions
    {
        public static void AddRange<T, TValue>(this ICollection<T> collection, IEnumerable<TValue> items) where TValue : T
        {
            foreach (TValue item in items)
                collection.Add(item);
        }
	}