namespace Class04.Homework.Extensions;

public static class PrintInConsole
{
    public static void Print<T>(this T item)
    {
        Console.WriteLine(item.ToString());
    }

    public static void PrintCollection<T>(this IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
