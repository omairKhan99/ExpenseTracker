using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form1 : Form
    {
        SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadExpenses();
        }

        private void InitializeDatabase()
        {
            connection = new SQLiteConnection("Data Source=ExpenseTracker.db;Version=3;");
            connection.Open();

            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Expenses (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Date DATE NOT NULL,
                                        Category TEXT NOT NULL,
                                        Amount DECIMAL NOT NULL,
                                        Description TEXT)";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }

        private void LoadExpenses()
        {
            string query = "SELECT * FROM Expenses";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewExpenses.DataSource = table;
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Expenses (Date, Category, Amount, Description) VALUES (@Date, @Category, @Amount, @Description)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Date", dateTimePicker.Value);
            command.Parameters.AddWithValue("@Category", comboBoxCategory.Text);
            command.Parameters.AddWithValue("@Amount", txtAmount.Text);
            command.Parameters.AddWithValue("@Description", txtDescription.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Expense added successfully!");
            LoadExpenses();
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewExpenses.SelectedRows[0].Cells[0].Value);
                string query = "DELETE FROM Expenses WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();

                MessageBox.Show("Expense deleted successfully!");
                LoadExpenses();
            }
        }

        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewExpenses.SelectedRows[0].Cells[0].Value);
                string query = "UPDATE Expenses SET Date = @Date, Category = @Category, Amount = @Amount, Description = @Description WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Date", dateTimePicker.Value);
                command.Parameters.AddWithValue("@Category", comboBoxCategory.Text);
                command.Parameters.AddWithValue("@Amount", txtAmount.Text);
                command.Parameters.AddWithValue("@Description", txtDescription.Text);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();

                MessageBox.Show("Expense updated successfully!");
                LoadExpenses();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // Clear the date picker
            dateTimePicker.Value = DateTime.Now;
            comboBoxCategory.SelectedIndex = -1;
            txtAmount.Clear();
            txtDescription.Clear();
            dataGridViewExpenses.ClearSelection();
        }

    }
}
