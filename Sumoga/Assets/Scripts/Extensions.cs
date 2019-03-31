using System;
using System.Collections.Generic;
using JetBrains.Annotations;

public static class Extensions
{
    public static void Each<T>([NotNull] this IEnumerable<T> ie, Action<T, int> action)
    {
        if (ie == null) throw new ArgumentNullException(nameof(ie));
        var i = 0;
        foreach (var e in ie) action(e, i++);
    }
    public static object TryConvertTo<T>(string input)
    {
        object result = null;
        try
        {
            result = Convert.ChangeType(input, typeof(T));
        }
        catch
        {
            // ignored
        }

        return result;
    }
}