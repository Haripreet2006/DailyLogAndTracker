using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DailyLogAndTracker.Helper;
using Microsoft.VisualBasic;

namespace DailyLogAndTracker.Forms
{
    public partial class Weekly : Form
    {
        public Weekly()
        {
            InitializeComponent();
        }

        private void WeeklyForm_Load(object sender, EventArgs e)
        {
            LoadDataDGV();
        }

        private void Weekly_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataDGV()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sSQL = "SELECT * FROM Weekly";
                using (var cmd = new SQLiteCommand(sSQL, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGVweekly.DataSource = dt;
                    DGVweekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToggleBtn_Click(object sender, EventArgs e)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();

                if (DGVweekly.SelectedCells.Count > 0 && DGVweekly.SelectedCells[0].OwningColumn.Name == "Completion")
                {
                    var selectedCell = DGVweekly.SelectedCells[0];
                    var row = selectedCell.OwningRow;
                    int serial = Convert.ToInt32(row.Cells["SerialNumber"].Value);

                    int currentStatus = Convert.ToInt32(row.Cells["Completion"].Value);
                    int newStatus = currentStatus == 0 ? 1 : 0;

                    string UpdateCompletion = "UPDATE Weekly SET Completion = " + newStatus + " WHERE SerialNumber = " + serial;

                    using (var cmd = new SQLiteCommand(UpdateCompletion, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("choose a the correct cell");
                }
            }
            LoadDataDGV();
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();

                string DateCheck = "SELECT 1 FROM Weekly WHERE Date = '" + DateTime.Today.ToString("dd MMMM yyyy") + "' LIMIT 1";
                using (var cmd = new SQLiteCommand(DateCheck, conn))
                {
                    Object IsDatePresent = cmd.ExecuteScalar();
                    if (IsDatePresent == null)
                    {
                        string InsertWeeklyTask = "INSERT INTO Weekly (Date, Task) VALUES ('" + DateTime.Today.ToString("dd MMMM yyyy") + "', '" + TaskInput.Text + "')";
                        using (var insertCmd = new SQLiteCommand(InsertWeeklyTask, conn))
                        {
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Task Added Successfuly");
                            LoadDataDGV();
                            TaskInput.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Task For the Week already Exists");
                    }
                }
            }
        }

        private void DelTaskBtn_Click(object sender, EventArgs e)
        {
            if (DGVweekly.SelectedRows.Count > 0)
            {
                int PrimKey = Convert.ToInt32(DGVweekly.SelectedRows[0].Cells[0].Value);

                var result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        string sSQL = "DELETE FROM Weekly WHERE SerialNumber = " + PrimKey;

                        using (var cmd = new SQLiteCommand(sSQL, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Task deleted.");
                        }
                    }

                    LoadDataDGV();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
        }

        private void DGVweekly_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Data Grid View formatting no changes being done to the Database core
            foreach (DataGridViewRow row in DGVweekly.Rows)
            {
                if (row.IsNewRow) continue;

                var cellcolumn = row.Cells["Completion"];

                int chckval = Convert.ToInt32(cellcolumn.Value);

                if (chckval == 0)
                {
                    cellcolumn.Style.ForeColor = Color.Red;
                    cellcolumn.Style.BackColor = Color.Red;
                }
                else
                {
                    cellcolumn.Style.ForeColor = Color.Green;
                    cellcolumn.Style.BackColor = Color.Green;
                }
            }
        }
    }
}
