﻿namespace DataStructuresFinalCalorieTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddFood = new Button();
            txtFoodName = new TextBox();
            label1 = new Label();
            FirstDailyLog = new ListBox();
            label2 = new Label();
            btnSortList = new Button();
            btnClearLog = new Button();
            txtCalories = new TextBox();
            lblTotalCalories = new Label();
            SuspendLayout();
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(235, 185);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(112, 34);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(235, 87);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(150, 31);
            txtFoodName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 93);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 2;
            label1.Text = "Food Name";
            // 
            // FirstDailyLog
            // 
            FirstDailyLog.FormattingEnabled = true;
            FirstDailyLog.ItemHeight = 25;
            FirstDailyLog.Location = new Point(587, 42);
            FirstDailyLog.Name = "FirstDailyLog";
            FirstDailyLog.Size = new Size(180, 129);
            FirstDailyLog.TabIndex = 3;
            FirstDailyLog.SelectedIndexChanged += FirstDailyLog_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 132);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Calories";
            // 
            // btnSortList
            // 
            btnSortList.Location = new Point(235, 225);
            btnSortList.Name = "btnSortList";
            btnSortList.Size = new Size(112, 34);
            btnSortList.TabIndex = 5;
            btnSortList.Text = "Sort List";
            btnSortList.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(235, 265);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(112, 34);
            btnClearLog.TabIndex = 6;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(235, 129);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(150, 31);
            txtCalories.TabIndex = 7;
            // 
            // lblTotalCalories
            // 
            lblTotalCalories.AutoSize = true;
            lblTotalCalories.Location = new Point(587, 183);
            lblTotalCalories.Name = "lblTotalCalories";
            lblTotalCalories.Size = new Size(135, 25);
            lblTotalCalories.TabIndex = 8;
            lblTotalCalories.Text = "Total Calories: 0";
            lblTotalCalories.Click += TotalCalories_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalCalories);
            Controls.Add(txtCalories);
            Controls.Add(btnClearLog);
            Controls.Add(btnSortList);
            Controls.Add(label2);
            Controls.Add(FirstDailyLog);
            Controls.Add(label1);
            Controls.Add(txtFoodName);
            Controls.Add(btnAddFood);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddFood;
        private TextBox txtFoodName;
        private Label label1;
        private ListBox FirstDailyLog;
        private Label label2;
        private Button btnSortList;
        private Button btnClearLog;
        private TextBox txtCalories;
        private Label lblTotalCalories;
    }
}
