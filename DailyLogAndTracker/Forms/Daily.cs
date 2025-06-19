using DailyLogAndTracker.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace DailyLogAndTracker
{
    public partial class Daily : Form
    {
        public Daily()
        {
            InitializeComponent();
            loadDGV();
        }

        private void Daily_Load(object sender, EventArgs e)
        {

        }

        private void loadDGV()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sSQL = "SELECT * FROM Daily";
                using (var cmd = new SQLiteCommand(sSQL, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGVout.DataSource = dt;
                    DGVout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string Input = TextInp.Text;
                string sSQL = "INSERT INTO DAILY (Date, Log) VALUES ('" + DateTime.Today.ToString("dd MMMM yyyy") + "', '" + Input + "')";
                using (var cmd = new SQLiteCommand(sSQL, conn))
                {
                    cmd.ExecuteNonQuery();
                    loadDGV();
                    TextInp.Clear();
                    MessageBox.Show("log successfully added");
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (DGVout.SelectedRows.Count > 0)
            {
                int primkey = Convert.ToInt32(DGVout.SelectedRows[0].Cells[0].Value);

                var Confirmation = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (Confirmation == DialogResult.Yes)
                {
                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        string DelQuery = "DELETE FROM Daily WHERE SerialNumber = " + primkey;
                        using (var cmd = new SQLiteCommand(DelQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully deleted the entry");
                        }

                        loadDGV();
                    }
                }

            }
            else
            {
                MessageBox.Show("Select a Row to delete");
            }
        }

        private void DGVout_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void TextInp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
