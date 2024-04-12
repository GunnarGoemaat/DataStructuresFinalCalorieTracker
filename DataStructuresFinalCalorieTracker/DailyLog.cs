using DataStructuresFinalCalorieTracker;

public class DailyLog
{
    public LinkedList<FoodItem> FoodItems { get; set; } = new LinkedList<FoodItem>();

    public void AddFoodItem(FoodItem item)
    {
        FoodItems.AddLast(item);
    }

    public int TotalCalories()
    {
        return FoodItems.Sum(item => item.Calories);
    }

    // https://dotnettutorials.net/lesson/insertion-sort-in-csharp/
    // Insertion sort algorithm for sorting the food items in the log.
    public void SortByCalories()
    {
        var node = FoodItems.First;
        while (node != null && node.Next != null)
        {
            var next = node.Next;
            var key = next.Value;
            var innerNode = node;
            while (innerNode != null && innerNode.Value.Calories < key.Calories)
            {
                innerNode.Next.Value = innerNode.Value;
                innerNode = innerNode.Previous;
            }
            if (innerNode == null)
                FoodItems.First.Value = key;
            else
                innerNode.Next.Value = key;

            node = next;
        }
    }
}
