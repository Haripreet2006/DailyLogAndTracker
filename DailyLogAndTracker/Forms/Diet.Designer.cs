namespace DailyLogAndTracker
{
    partial class Diet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel4 = new Panel();
            AddBtn = new Button();
            FoodInp = new RichTextBox();
            panel3 = new Panel();
            DGVdiet = new DataGridView();
            CalGoal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CarbGoal = new TextBox();
            label3 = new Label();
            ProteinGoal = new TextBox();
            label4 = new Label();
            FatGoal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            StreakCount = new Label();
            label11 = new Label();
            FibGoal = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVdiet).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 147);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(AddBtn);
            panel4.Controls.Add(FoodInp);
            panel4.Location = new Point(26, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(1093, 74);
            panel4.TabIndex = 0;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkGreen;
            AddBtn.Dock = DockStyle.Right;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            AddBtn.ForeColor = SystemColors.ControlLightLight;
            AddBtn.Location = new Point(817, 0);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(276, 74);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "ADD!!";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // FoodInp
            // 
            FoodInp.Dock = DockStyle.Fill;
            FoodInp.Font = new Font("Segoe UI", 15F);
            FoodInp.Location = new Point(0, 0);
            FoodInp.Name = "FoodInp";
            FoodInp.Size = new Size(1093, 74);
            FoodInp.TabIndex = 0;
            FoodInp.Text = "";
            // 
            // panel3
            // 
            panel3.Controls.Add(DGVdiet);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(1152, 356);
            panel3.TabIndex = 2;
            // 
            // DGVdiet
            // 
            DGVdiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVdiet.BackgroundColor = Color.FromArgb(42, 39, 89);
            DGVdiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVdiet.Location = new Point(26, 0);
            DGVdiet.Name = "DGVdiet";
            DGVdiet.Size = new Size(1093, 356);
            DGVdiet.TabIndex = 0;
            DGVdiet.DataBindingComplete += DGVdiet_DataBindingComplete;
            // 
            // CalGoal
            // 
            CalGoal.Anchor = AnchorStyles.None;
            CalGoal.Location = new Point(153, 42);
            CalGoal.Name = "CalGoal";
            CalGoal.Size = new Size(255, 23);
            CalGoal.TabIndex = 0;
            CalGoal.TextChanged += CalGoal_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 15F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 1;
            label1.Text = "Calorie Goal:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 15F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(423, 40);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 2;
            label2.Text = "Carbs Goal:";
            // 
            // CarbGoal
            // 
            CarbGoal.Anchor = AnchorStyles.None;
            CarbGoal.Location = new Point(549, 41);
            CarbGoal.Name = "CarbGoal";
            CarbGoal.Size = new Size(55, 23);
            CarbGoal.TabIndex = 3;
            CarbGoal.TextChanged += CarbGoal_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 15F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(423, 78);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 4;
            label3.Text = "Protein Goal:";
            // 
            // ProteinGoal
            // 
            ProteinGoal.Anchor = AnchorStyles.None;
            ProteinGoal.Location = new Point(549, 79);
            ProteinGoal.Name = "ProteinGoal";
            ProteinGoal.Size = new Size(55, 23);
            ProteinGoal.TabIndex = 5;
            ProteinGoal.TextChanged += ProteinGoal_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 15F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(623, 41);
            label4.Name = "label4";
            label4.Size = new Size(77, 24);
            label4.TabIndex = 6;
            label4.Text = "Fat Goal:";
            // 
            // FatGoal
            // 
            FatGoal.Anchor = AnchorStyles.None;
            FatGoal.Location = new Point(749, 42);
            FatGoal.Name = "FatGoal";
            FatGoal.Size = new Size(55, 23);
            FatGoal.TabIndex = 7;
            FatGoal.TextChanged += FatGoal_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 10F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(423, 18);
            label8.Name = "label8";
            label8.Size = new Size(83, 17);
            label8.TabIndex = 14;
            label8.Text = "(All in grams)";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiCondensed", 10F);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(27, 24);
            label9.Name = "label9";
            label9.Size = new Size(53, 17);
            label9.TabIndex = 15;
            label9.Text = "(in kcal)";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiCondensed", 15F);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(623, 79);
            label12.Name = "label12";
            label12.Size = new Size(91, 24);
            label12.TabIndex = 20;
            label12.Text = "Fibre Goal:";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel5);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(870, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(282, 126);
            panel6.TabIndex = 19;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(42, 39, 89);
            panel5.Controls.Add(StreakCount);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(69, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(119, 108);
            panel5.TabIndex = 18;
            panel5.Paint += panel5_Paint;
            // 
            // StreakCount
            // 
            StreakCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StreakCount.AutoSize = true;
            StreakCount.Font = new Font("Bahnschrift SemiCondensed", 40F);
            StreakCount.ForeColor = SystemColors.Control;
            StreakCount.Location = new Point(21, 34);
            StreakCount.Name = "StreakCount";
            StreakCount.Size = new Size(79, 65);
            StreakCount.TabIndex = 20;
            StreakCount.Text = "00";
            StreakCount.TextAlign = ContentAlignment.MiddleCenter;
            StreakCount.Click += StreakCount_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiCondensed", 15F);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(6, 5);
            label11.Name = "label11";
            label11.Size = new Size(110, 24);
            label11.TabIndex = 19;
            label11.Text = "Streak Count";
            label11.Click += label11_Click;
            // 
            // FibGoal
            // 
            FibGoal.Anchor = AnchorStyles.None;
            FibGoal.Location = new Point(749, 80);
            FibGoal.Name = "FibGoal";
            FibGoal.Size = new Size(55, 23);
            FibGoal.TabIndex = 21;
            FibGoal.TextChanged += FibGoal_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(FibGoal);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(FatGoal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ProteinGoal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CarbGoal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CalGoal);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 126);
            panel1.TabIndex = 0;
            // 
            // Diet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 18, 43);
            ClientSize = new Size(1152, 629);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diet";
            Text = "Diet";
            Load += Diet_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVdiet).EndInit();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private Button AddBtn;
        private RichTextBox FoodInp;
        private Panel panel3;
        private DataGridView DGVdiet;
        private TextBox CalGoal;
        private Label label1;
        private Label label2;
        private TextBox CarbGoal;
        private Label label3;
        private TextBox ProteinGoal;
        private Label label4;
        private TextBox FatGoal;
        private Label label8;
        private Label label9;
        private Label label12;
        private Panel panel6;
        private Panel panel5;
        private Label StreakCount;
        private Label label11;
        private TextBox FibGoal;
        private Panel panel1;
    }
}