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
            MessageBox.Show("Expense added successfully!");
            LoadExpenses();
        }

        
    }
}
