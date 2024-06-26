﻿using DataStructuresFinalCalorieTracker;

public class DailyLog
{
    public LinkedList<FoodItem> FoodItems { get; set; } = new LinkedList<FoodItem>();
    public Stack<FoodItem> RecentFoodItems { get; set; } = new Stack<FoodItem>();
    public void AddFoodItem(FoodItem item)
    {
        FoodItems.AddLast(item); // Add the food item to the end of the list
        RecentFoodItems.Push(item);
    }
    public FoodItem RemoveRecentFoodItem()
    {
        if (RecentFoodItems.Count > 0)
        {
            FoodItem itemToRemove = RecentFoodItems.Pop();
            FoodItems.Remove(itemToRemove);
            return itemToRemove;
        }
        return null;
    }
    public int TotalCalories()
    {
        return FoodItems.Sum(item => item.Calories);
    }
    
    // https://dotnettutorials.net/lesson/insertion-sort-in-csharp/
    // Insertion sort algorithm for sorting the food items in the log.
    public void SortByCalories()
    {
        if (FoodItems.First == null) return; // Check if empty

        bool swapped;
        do
        {
            swapped = false;
            var node = FoodItems.First;

            while (node.Next != null)
            {
                if (node.Value.Calories < node.Next.Value.Calories)
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
