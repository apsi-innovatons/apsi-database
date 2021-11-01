using System.Collections.Generic;
using System.Linq;
using GenFu;

namespace Apsi.Database
{
    public static class GenfuHelper
    {
        private static IEnumerable<T> GetRandom<T>(this IEnumerable<T> source, int min, int max)
        {
            var length = source.Count();
            var index = A.Random.Next(0, length - 1);
            var count = A.Random.Next(min, max);

            return source.Skip(index).Take(count);
        }

        public static GenFuConfigurator<TType> AsRandom<TType, TData>(
            this GenFuComplexPropertyConfigurator<TType, List<TData>> configurator,
            IEnumerable<TData> data, int min, int max)
            where TType : new()
        {
            configurator.Maggie.RegisterFiller(
                new CustomFiller<IEnumerable<TData>>(
                    configurator.PropertyInfo.Name, typeof(TType),
                    () => data.GetRandom(min, max)));

            return configurator;
        }

    }
}