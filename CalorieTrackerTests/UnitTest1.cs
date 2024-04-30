using DataStructuresFinalCalorieTracker;
using Xunit;

namespace CalorieTrackerTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddsFoodItemToDatabase()
        {
            // Arrange
            var tracker = new CalorieTracker();
            string name = "apple";
            int calories = 98;

            // Act 
            tracker.AddFoodToDatabase(name, calories);

            var result = tracker.GetFoodItemFromDatabase(name);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(name, result.Name);
            Assert.Equal(calories, result.Calories);
        }


        [Fact]
        public void AddsFoodItemToDailyLogFromDatabase()
        {
            //arrange
            var tracker = new CalorieTracker();
            string name = "Apple";
            int calories = 52;
            tracker.AddFoodToDatabase(name, calories);

            //act 
            tracker.AddFoodToLog(name);
            var result = tracker.GetDailyLog().FoodItems;

            //assert
            Assert.Contains(result, fi => fi.Name == name);
        }

        [Fact]
        public void DoesNotAddFoodItemToDailyLogIfNotInDatabase()
        {
            //arrange
            var tracker = new CalorieTracker();
            string name = "Apple";

            //act 
            tracker.AddFoodToLog(name);
            var result = tracker.GetDailyLog().FoodItems;

            //assert
            Assert.DoesNotContain(result, fi => fi.Name == name);
        }

        [Fact]
        public void SortsDailyLogByCalories()
        {
            //arrange
            var tracker = new CalorieTracker();
            tracker.AddFoodToDatabase("LowCalFood", 10);
            tracker.AddFoodToDatabase("HighCalFood", 500);
            tracker.AddFoodToLog("LowCalFood");
            tracker.AddFoodToLog("HighCalFood");

            //act 
            tracker.GetDailyLog().SortByCalories();

            //assert
            Assert.Equal("LowCalFood", tracker.GetDailyLog().FoodItems.First.Value.Name);
        }

        [Fact]
        public void CalculatesTotalCaloriesCorrectly()
        {
            //arrange
            var tracker = new CalorieTracker();
            tracker.AddFoodToDatabase("Food1", 250);
            tracker.AddFoodToLog("Food1");
            tracker.AddFoodToDatabase("Food2", 300);
            tracker.AddFoodToLog("Food2");

            //act 
            int totalCalories = tracker.GetDailyLog().TotalCalories();

            //assert
            Assert.Equal(550, totalCalories);
        }
    }
}