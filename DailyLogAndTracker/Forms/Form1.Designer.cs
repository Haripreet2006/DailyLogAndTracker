namespace DailyLogAndTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Menu = new Panel();
            NukeBtn = new Button();
            WeeklyBtn = new Button();
            DailyBtn = new Button();
            DietBtn = new Button();
            HomeBtn = new Button();
            Content = new Panel();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Menu.AutoSize = true;
            Menu.BackColor = Color.FromArgb(9, 0, 38);
            Menu.Controls.Add(NukeBtn);
            Menu.Controls.Add(WeeklyBtn);
            Menu.Controls.Add(DailyBtn);
            Menu.Controls.Add(DietBtn);
            Menu.Controls.Add(HomeBtn);
            Menu.Location = new Point(-7, -4);
            Menu.Name = "Menu";
            Menu.Size = new Size(248, 595);
            Menu.TabIndex = 0;
            Menu.Paint += Menu_Paint;
            // 
            // NukeBtn
            // 
            NukeBtn.BackColor = Color.FromArgb(192, 0, 0);
            NukeBtn.Dock = DockStyle.Bottom;
            NukeBtn.FlatAppearance.BorderSize = 0;
            NukeBtn.FlatStyle = FlatStyle.Flat;
            NukeBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            NukeBtn.ForeColor = Color.White;
            NukeBtn.Location = new Point(0, 508);
            NukeBtn.Name = "NukeBtn";
            NukeBtn.Size = new Size(248, 87);
            NukeBtn.TabIndex = 4;
            NukeBtn.Text = "NUKE DATA!!";
            NukeBtn.UseVisualStyleBackColor = false;
            NukeBtn.Click += NukeBtn_Click;
            // 
            // WeeklyBtn
            // 
            WeeklyBtn.BackColor = Color.FromArgb(57, 48, 83);
            WeeklyBtn.Dock = DockStyle.Top;
            WeeklyBtn.FlatAppearance.BorderSize = 0;
            WeeklyBtn.FlatStyle = FlatStyle.Flat;
            WeeklyBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            WeeklyBtn.ForeColor = Color.FromArgb(143, 214, 225);
            WeeklyBtn.Location = new Point(0, 258);
            WeeklyBtn.Name = "WeeklyBtn";
            WeeklyBtn.Size = new Size(248, 58);
            WeeklyBtn.TabIndex = 3;
            WeeklyBtn.Text = "Weekly log";
            WeeklyBtn.UseVisualStyleBackColor = false;
            WeeklyBtn.Click += WeeklyBtn_Click;
            // 
            // DailyBtn
            // 
            DailyBtn.BackColor = Color.FromArgb(9, 0, 38);
            DailyBtn.Dock = DockStyle.Top;
            DailyBtn.FlatAppearance.BorderSize = 0;
            DailyBtn.FlatStyle = FlatStyle.Flat;
            DailyBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            DailyBtn.ForeColor = Color.FromArgb(143, 214, 225);
            DailyBtn.Location = new Point(0, 200);
            DailyBtn.Name = "DailyBtn";
            DailyBtn.Size = new Size(248, 58);
            DailyBtn.TabIndex = 2;
            DailyBtn.Text = "Daily Log";
            DailyBtn.UseVisualStyleBackColor = false;
            DailyBtn.Click += DailyBtn_Click_1;
            // 
            // DietBtn
            // 
            DietBtn.BackColor = Color.FromArgb(57, 48, 83);
            DietBtn.Dock = DockStyle.Top;
            DietBtn.FlatAppearance.BorderSize = 0;
            DietBtn.FlatStyle = FlatStyle.Flat;
            DietBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DietBtn.ForeColor = Color.FromArgb(143, 214, 225);
            DietBtn.Location = new Point(0, 142);
            DietBtn.Name = "DietBtn";
            DietBtn.Size = new Size(248, 58);
            DietBtn.TabIndex = 1;
            DietBtn.Text = "Diet Log";
            DietBtn.UseVisualStyleBackColor = false;
            DietBtn.Click += DietBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.FromArgb(9, 0, 38);
            HomeBtn.Dock = DockStyle.Top;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.Location = new Point(0, 0);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(248, 142);
            HomeBtn.TabIndex = 0;
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // Content
            // 
            Content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Content.BackColor = Color.FromArgb(24, 18, 43);
            Content.Location = new Point(241, 0);
            Content.Name = "Content";
            Content.Size = new Size(901, 588);
            Content.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 2, 73);
            ClientSize = new Size(1142, 588);
            Controls.Add(Menu);
            Controls.Add(Content);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daily Log And Tracker";
            WindowState = FormWindowState.Maximized;
            Menu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Menu;
        private Button HomeBtn;
        private Button WeeklyBtn;
        private Button DailyBtn;
        private Button DietBtn;
        private Button NukeBtn;
        private Panel Content;
    }
}
