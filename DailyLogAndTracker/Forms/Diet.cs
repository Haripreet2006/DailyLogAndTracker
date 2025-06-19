using DailyLogAndTracker.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DailyLogAndTracker.Helper;
using Microsoft.VisualBasic;
using DailyLogAndTracker.Properties;
using System.Data.SQLite;

namespace DailyLogAndTracker
{
    public partial class Diet : Form
    {
        public Diet()
        {
            InitializeComponent();
            LoadDGV();
            CreateNewDay();
            UpdateCount();
        }



        private async void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float carbs;
                float prots;
                float fats;
                float fibrs;
                float cals;

                float tempCB = 0;
                float tempPR = 0;
                float tempFT = 0;
                float tempFB = 0;
                float tempCL = 0;

                int SrNo = 0;

                foreach (DataGridViewRow row in DGVdiet.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[1].Value.ToString() == DateTime.Today.ToString("dd MMMM yyyy"))
                    {
                        tempCB = float.Parse(row.Cells[2].Value.ToString());
                        tempPR = float.Parse(row.Cells[3].Value.ToString());
                        tempFT = float.Parse(row.Cells[4].Value.ToString());
                        tempFB = float.Parse(row.Cells[5].Value.ToString());
                        tempCL = float.Parse(row.Cells[6].Value.ToString());
                        SrNo = Convert.ToInt32(row.Cells[0].Value.ToString());
                    }
                }

                string APIResponse = await AIHelper.GetDietData(FoodInp.Text);

                string msg = JsonDocument.Parse(APIResponse).RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").ToString();

                string NutritionJsonRaw = Regex.Match(msg, @"\{[^{}]*\}").Value;

                if (NutritionJsonRaw != null)
                {

                    MessageBox.Show(NutritionJsonRaw + "\n\nTotal Tokens Used: " + JsonDocument.Parse(APIResponse).RootElement.GetProperty("usage").GetProperty("total_tokens").ToString(), "API Response");
                    if (float.TryParse(JsonDocument.Parse(NutritionJsonRaw).RootElement.GetProperty("Calories").ToString(), out cals))
                    {
                        cals += tempCL;
                    }
                    else
                    {
                        MessageBox.Show("error", "error");
                    }
                    if (float.TryParse(JsonDocument.Parse(NutritionJsonRaw).RootElement.GetProperty("Protein").ToString(), out prots))
                    {
                        prots += tempPR;
                    }
                    else
                    {
                        MessageBox.Show("error", "error");
                    }
                    if (float.TryParse(JsonDocument.Parse(NutritionJsonRaw).RootElement.GetProperty("Carbohydrates").ToString(), out carbs))
                    {
                        carbs += tempCB;
                    }
                    else
                    {
                        MessageBox.Show("error", "error");
                    }
                    if (float.TryParse(JsonDocument.Parse(NutritionJsonRaw).RootElement.GetProperty("Fats").ToString(), out fats))
                    {
                        fats += tempFT;
                    }
                    else
                    {
                        MessageBox.Show("error", "error");
                    }
                    if (float.TryParse(JsonDocument.Parse(NutritionJsonRaw).RootElement.GetProperty("Fibre").ToString(), out fibrs))
                    {
                        fibrs += tempFB;
                    }
                    else
                    {
                        MessageBox.Show("error", "error");
                    }

                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        string sSQL = "UPDATE diet SET Carbs = " + carbs + ", Protien = " + prots + ", Fats = " + fats + ", Fibre = " + fibrs + ", Calories = " + cals + " WHERE SerialNumber = " + SrNo;
                        using (var InsertCmd = new SQLiteCommand(sSQL, conn))
                        {
                            InsertCmd.ExecuteNonQuery();
                            LoadDGV();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("error", "API Response");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDGV()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sSQL = "SELECT * FROM diet";
                using (var cmd = new SQLiteCommand(sSQL, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGVdiet.DataSource = dt;
                    DGVdiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void Diet_Load(object sender, EventArgs e)
        {
            CalGoal.Text = Properties.Settings.Default.Calories.ToString();
            ProteinGoal.Text = Properties.Settings.Default.Protiens.ToString();
            CarbGoal.Text = Properties.Settings.Default.Carbohydrates.ToString();
            FatGoal.Text = Properties.Settings.Default.Fats.ToString();
            FibGoal.Text = Properties.Settings.Default.Fibres.ToString();
        }

        private void CalGoal_TextChanged(object sender, EventArgs e)
        {
            float changeVar;
            bool success = float.TryParse(CalGoal.Text, out changeVar);
            if (success)
            {
                Properties.Settings.Default.Calories = changeVar;
                Properties.Settings.Default.Save();
            }
        }

        private void CarbGoal_TextChanged(object sender, EventArgs e)
        {
            float changeVar;
            bool success = float.TryParse(CarbGoal.Text, out changeVar);
            if (success)
            {
                Properties.Settings.Default.Carbohydrates = changeVar;
                Properties.Settings.Default.Save();
            }
        }

        private void ProteinGoal_TextChanged(object sender, EventArgs e)
        {
            float changeVar;
            bool success = float.TryParse(ProteinGoal.Text, out changeVar);
            if (success)
            {
                Properties.Settings.Default.Protiens = changeVar;
                Properties.Settings.Default.Save();
            }
        }

        private void FatGoal_TextChanged(object sender, EventArgs e)
        {
            float changeVar;
            bool success = float.TryParse(FatGoal.Text, out changeVar);
            if (success)
            {
                Properties.Settings.Default.Fats = changeVar;
                Properties.Settings.Default.Save();
            }
        }

        private void FibGoal_TextChanged(object sender, EventArgs e)
        {
            float changeVar;
            bool success = float.TryParse(FibGoal.Text, out changeVar);
            if (success)
            {
                Properties.Settings.Default.Fibres = changeVar;
                Properties.Settings.Default.Save();
            }
        }

        private void DGVdiet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in DGVdiet.Rows)
            {
                float carbs;
                float prots;
                float fats;
                float fibrs;
                float cals;

                row.Cells[2].Style.ForeColor = Color.White;
                row.Cells[3].Style.ForeColor = Color.White;
                row.Cells[4].Style.ForeColor = Color.White;
                row.Cells[5].Style.ForeColor = Color.White;
                row.Cells[6].Style.ForeColor = Color.White;

                if (float.TryParse(row.Cells[2].Value?.ToString(), out carbs))
                {
                    if (carbs >= Properties.Settings.Default.Carbohydrates)
                    {
                        row.Cells[2].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        row.Cells[2].Style.BackColor = Color.Red;
                    }
                }
                if (float.TryParse(row.Cells[3].Value?.ToString(), out prots))
                {
                    if (prots >= Properties.Settings.Default.Protiens)
                    {
                        row.Cells[3].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        row.Cells[3].Style.BackColor = Color.Red;
                    }
                }
                if (float.TryParse(row.Cells[4].Value?.ToString(), out fats))
                {
                    if (fats >= Properties.Settings.Default.Fats)
                    {
                        row.Cells[4].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        row.Cells[4].Style.BackColor = Color.Red;
                    }
                }
                if (float.TryParse(row.Cells[5].Value?.ToString(), out fibrs))
                {
                    if (fibrs >= Properties.Settings.Default.Fibres)
                    {
                        row.Cells[5].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        row.Cells[5].Style.BackColor = Color.Red;
                    }
                }
                if (float.TryParse(row.Cells[6].Value?.ToString(), out cals))
                {
                    if (cals >= Properties.Settings.Default.Calories)
                    {
                        row.Cells[6].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        row.Cells[6].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void CreateNewDay()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string DateCheck = "SELECT 1 FROM diet WHERE Date = '" + DateTime.Today.ToString("dd MMMM yyyy") + "' LIMIT 1";
                using (var cmd = new SQLiteCommand(DateCheck, conn))
                {
                    Object IsDatePresent = cmd.ExecuteScalar();
                    if (IsDatePresent == null)
                    {
                        string InsertEntry = "INSERT INTO diet (Date) VALUES ('" + DateTime.Today.ToString("dd MMMM yyyy") + "')";
                        using (var InsertCmd = new SQLiteCommand(InsertEntry, conn))
                        {
                            InsertCmd.ExecuteNonQuery();
                            LoadDGV();
                        }
                    }
                }
            }
        }

        private void UpdateCount()
        {
            int count = 0;

            foreach (DataGridViewRow row in DGVdiet.Rows)
            {
                if (row.IsNewRow) continue;
                float tempCB = float.Parse(row.Cells[2].Value.ToString());
                float tempPR = float.Parse(row.Cells[3].Value.ToString());
                float tempFT = float.Parse(row.Cells[4].Value.ToString());
                float tempCL = float.Parse(row.Cells[6].Value.ToString());
                if (tempCB >= Properties.Settings.Default.Carbohydrates && tempPR >= Properties.Settings.Default.Protiens && tempFT >= Properties.Settings.Default.Fats && tempCL >= Properties.Settings.Default.Calories)
                {
                    count++;
                }
            }

            StreakCount.Text = count.ToString();
        }

        private void StreakCount_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
