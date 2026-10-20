using System;

namespace GenericsPart;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> values,int pageNumber, int pageSize)
    {
        if (pageNumber <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(pageNumber));
        }
        if (pageSize <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(pageSize));
        }

        int skippeditems = (pageNumber - 1) * pageSize;
        int currentIdx = 0;

        foreach(var item in values)
        {
            if (currentIdx >= skippeditems && currentIdx < skippeditems + pageSize)
            {
                yield return item;
            }

            currentIdx++;

            if (currentIdx >= skippeditems + pageSize)
            {
                yield break;
            }
        }
    }


    public static T? FindById<T>(this IEnumerable<T> values, int id) where T : IHasId
    {
        foreach(var item in values)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> values) where T : IHasId
    {
        var dict = new Dictionary<int, T>();

        foreach(var item in values)
        {
            dict.Add(item.Id, item);
        }
        return dict;
    }
}
