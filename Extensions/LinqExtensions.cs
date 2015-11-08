using System.Collections.Generic;
using System.Linq;
using FinalstreamCommons.Comparers;

namespace FinalstreamCommons.Extensions
{
    public static class LinqExtensions
    {
        /// <summary>
        /// Json形式にシリアライズして比較したEnumerableの差分を取得します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static IEnumerable<T> ExceptUsingJsonCompare<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            return first.Except(second, new JsonEqualityComparer<T>());
        }
    }
}