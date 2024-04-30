namespace DataStructuresFinalCalorieTracker
{
    public partial class Form1 : Form
    {
        // Assuming you have a class or method to create an instance of CalorieTracker
        private CalorieTracker calorieTracker = new CalorieTracker();

        public Form1()
        {
            InitializeComponent();
            // Add event handlers
            this.btnAddFood.Click += new EventHandler(btnAddFood_Click);
            this.btnSortList.Click += new EventHandler(btnSortList_Click);
            this.btnClearLog.Click += new EventHandler(btnClearLog_Click);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // Input validation
            if (!int.TryParse(txtCalories.Text, out int calories) || calories < 0 || string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Please enter a valid food name and a positive calorie amount.");
                return;
            }

            string foodName = txtFoodName.Text;

            // Add food to tracker and list
            if (!calorieTracker.GetDailyLog().FoodItems.Any(item => item.Name == foodName))
            {
                calorieTracker.AddFoodToDatabase(foodName, calories);
                calorieTracker.AddFoodToLog(foodName);
                UpdateDailyLogUI();
            }
        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            // Sort the daily log
            calorieTracker.GetDailyLog().SortByCalories();
            UpdateDailyLogUI();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            // Clear the daily log
            calorieTracker.GetDailyLog().FoodItems.Clear();
            UpdateDailyLogUI();
        }

        private void UpdateDailyLogUI()
        {
            // Clear the list box with the current food items.
            FirstDailyLog.Items.Clear();

            // Add each food item to the list box from the daily log.
            foreach (var item in calorieTracker.GetDailyLog().FoodItems)
            {
                FirstDailyLog.Items.Add($"{item.Name} - {item.Calories} cal");
            }

            // Update the total calories label.
            lblTotalCalories.Text = $"Total Calories: {calorieTracker.GetDailyLog().TotalCalories()}";
        }

        private void TotalCalories_Click(object sender, EventArgs e)
        {

        }

        private void FirstDailyLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSortList_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click_1(object sender, EventArgs e)
        {
            FoodItem removedItem = calorieTracker.GetDailyLog().RemoveRecentFoodItem();

            if (removedItem == null)
            {
                MessageBox.Show("There is nothing to undo.", "Undo Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UpdateDailyLogUI();
            }
        }
    }

}
