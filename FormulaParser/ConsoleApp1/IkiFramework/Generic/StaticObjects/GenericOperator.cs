namespace IkiCore.Generic
{
	public static class GenericOperator
    {
        public static bool LessThan<T>(this T l, T r) where T : System.IComparable<T> => l.CompareTo(r) < 0;
        public static bool LessThanOrEqual<T>(this T l, T r) where T : System.IComparable<T> => l.CompareTo(r) <= 0;
        public static bool GreaterThan<T>(this T l, T r) where T : System.IComparable<T> => l.CompareTo(r) > 0;
        public static bool GreaterThanOrEqual<T>(this T l, T r) where T : System.IComparable<T> => l.CompareTo(r) > 0;
        public static bool EqualTo<T>(this T l, T r) where T : System.IComparable<T> => l.CompareTo(r) == 0;
    }
}
