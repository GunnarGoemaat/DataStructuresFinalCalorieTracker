using DataStructuresFinalCalorieTracker;

public class CalorieTracker
{
    private Dictionary<string, FoodItem> FoodDatabase = new Dictionary<string, FoodItem>();
    private DailyLog Log = new DailyLog();

    public void AddFoodToDatabase(string name, int calories)
    {
        if (!FoodDatabase.ContainsKey(name))
        {
            FoodDatabase.Add(name, new FoodItem(name, calories));
        }
    }
    public FoodItem GetFoodItemFromDatabase(string name)
    {
        FoodDatabase.TryGetValue(name, out FoodItem item);
        return item;
    }
    public void AddFoodToLog(string name)
    {
        if (FoodDatabase.TryGetValue(name, out FoodItem item))
        {
            Log.AddFoodItem(item);
        }
    }

    public DailyLog GetDailyLog()
    {
        return Log;
    }
}

