using Class04.Task3.Models;

public static class VehicleExtensions
{
    public static void PrintAll<T>(this IEnumerable<T> items) where T : Vehicle
    {
        foreach (T item in items)
        {
            item.DisplayInfo();
        }
    }


}
