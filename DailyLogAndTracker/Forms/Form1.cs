using DailyLogAndTracker.Forms;
using DailyLogAndTracker.Helper;
using System.Data.SQLite;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DailyLogAndTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadForm(new Diet());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void DailyBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Daily());
        }

        public void LoadForm(object formObject)
        {
            if (this.Content.Controls.Count > 0)
                this.Content.Controls.Clear();
            Form f = formObject as Form;  //declaring an object f
            f.TopLevel = false;           //setting the property
            f.Dock = DockStyle.Fill;      //dock style to make sure no scaling issue
            this.Content.Controls.Add(f); //adds to panel
            this.Content.Tag = f;         //tagging the panel with the form
            f.Show();                     //showing the form
        }

        private void DietBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Diet());
        }

        private void WeeklyBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Weekly());
        }

        private void DailyBtn_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Daily());
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void NukeBtn_Click(object sender, EventArgs e)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sSQL = "DELETE FROM Daily; DELETE FROM Weekly; DELETE FROM diet";
                using (var InsertCmd = new SQLiteCommand(sSQL, conn))
                {
                    InsertCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
