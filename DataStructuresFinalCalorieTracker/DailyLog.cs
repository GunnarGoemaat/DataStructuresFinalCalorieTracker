using DataStructuresFinalCalorieTracker;

public class DailyLog
{
    public LinkedList<FoodItem> FoodItems { get; set; } = new LinkedList<FoodItem>();

    public void AddFoodItem(FoodItem item)
    {
        FoodItems.AddLast(item); // Add the food item to the end of the list
    }

    public int TotalCalories()
    {
        return FoodItems.Sum(item => item.Calories);
    }
    
    // https://dotnettutorials.net/lesson/insertion-sort-in-csharp/
    // Insertion sort algorithm for sorting the food items in the log.
    public void SortByCalories()
    {
        if (FoodItems.First == null) return; // No need to sort if the list is empty

        bool swapped;
        do
        {
            swapped = false;
            var node = FoodItems.First;

            while (node.Next != null)
            {
                if (node.Value.Calories > node.Next.Value.Calories)
                {
                    // Swap nodes by swapping the values they hold
                    var temp = node.Value;
                    node.Value = node.Next.Value;
                    node.Next.Value = temp;
                    swapped = true;
                }

                node = node.Next;
            }
        } while (swapped); // Continue while swaps are made
    } // This took a lot of time and revisions to get right!
}
