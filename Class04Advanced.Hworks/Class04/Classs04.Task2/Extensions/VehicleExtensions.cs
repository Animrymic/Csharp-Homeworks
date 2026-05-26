using Classs04.Task2.Models;

namespace Classs04.Task2.Extensions;

public static class VehicleExtensions
{
    public static void PrintAll<T>(this IEnumerable<T> items) where T : Vehicle
    {
        foreach (T item in items)
        {
            item.DIsplayInfo();
        }
    }


}
