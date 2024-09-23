using System.Collections.Generic;

namespace ExpenseTracker
{
    partial class Form1
    {
        private System.Windows.Forms.DataGridView dataGridViewExpenses;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label lblTotalAmount; 

        private void InitializeComponent()
        {
            this.dataGridViewExpenses = new System.Windows.Forms.DataGridView();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button(); 
            this.btnTotal = new System.Windows.Forms.Button(); 
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label(); 


            // Initialize components properties

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).BeginInit();
            this.SuspendLayout();

            // DataGridView for expenses
            this.dataGridViewExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenses.Location = new System.Drawing.Point(12, 150);
            this.dataGridViewExpenses.Name = "dataGridViewExpenses";
            this.dataGridViewExpenses.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewExpenses.TabIndex = 0;

            // Add Expense Button
            this.btnAddExpense.Location = new System.Drawing.Point(700, 20);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(88, 30);
            this.btnAddExpense.TabIndex = 1;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // Set button colors
            this.btnAddExpense.BackColor = System.Drawing.Color.LightGreen;   // Background color
            this.btnAddExpense.ForeColor = System.Drawing.Color.DarkGreen;    // Text color

            // Edit Expense Button
            this.btnEditExpense.Location = new System.Drawing.Point(700, 60);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(88, 30);
            this.btnEditExpense.TabIndex = 2;
            this.btnEditExpense.Text = "Edit Expense";
            this.btnEditExpense.UseVisualStyleBackColor = true;
            this.btnEditExpense.Click += new System.EventHandler(this.btnEditExpense_Click);
            // Set button colors
            this.btnEditExpense.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditExpense.ForeColor = System.Drawing.Color.DarkBlue;

            // Delete Expense Button
            this.btnDeleteExpense.Location = new System.Drawing.Point(700, 100);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteExpense.TabIndex = 3;
            this.btnDeleteExpense.Text = "Delete Expense";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // Set button colors
            this.btnDeleteExpense.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteExpense.ForeColor = System.Drawing.Color.DarkRed;

            // Button to clear all fields
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearAll.Location = new System.Drawing.Point(360, 110);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(100, 20);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // Set button colors
            this.btnClearAll.BackColor = System.Drawing.Color.LightGray;
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;

            // DateTimePicker for date
            this.dateTimePicker.Location = new System.Drawing.Point(110, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;

            // ComboBox for category
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] { "Food", "Transport", "Rent", "Shopping", "Health", "Others" });
            this.comboBoxCategory.Location = new System.Drawing.Point(110, 50);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory.TabIndex = 5;

            // TextBox for amount
            this.txtAmount.Location = new System.Drawing.Point(110, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 6;

            // TextBox for description
            this.txtDescription.Location = new System.Drawing.Point(110, 110);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 7;

            // Label for Date
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date:";

            // Label for Category
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 55);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Category:";

            // Label for Amount
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 85);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount:";

            // Label for Description
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 115);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Description:";

            // Total Amount Label
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(12, 420);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(64, 13);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "Total: $0.00";

            // Clear Selection Button
            this.btnClearSelection.Location = new System.Drawing.Point(480, 110);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(100, 20);
            this.btnClearSelection.TabIndex = 16;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);

            // Total Button
            this.btnTotal.Location = new System.Drawing.Point(700, 400);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(88, 30);
            this.btnTotal.TabIndex = 17;
            this.btnTotal.Text = "Calculate Total";
            this.btnTotal.UseVisualStyleBackColor = true;

            // Adding components to the form
            this.Controls.Add(this.dataGridViewExpenses);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnEditExpense);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnTotal);

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

