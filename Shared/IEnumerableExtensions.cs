using System.Collections;

namespace NewBlazor.Shared
{
    public static class IEnumerableExtensions
    {
        public static bool Any(this IEnumerable enumerable)
        {
            return enumerable.GetEnumerator().MoveNext() == true;
        }
    }
}
