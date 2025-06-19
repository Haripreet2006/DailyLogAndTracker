namespace DailyLogAndTracker.Forms
{
    partial class Weekly
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
            panel1 = new Panel();
            AddTaskBtn = new Button();
            DelTaskBtn = new Button();
            ToggleBtn = new Button();
            panel4 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            TaskInput = new RichTextBox();
            panel3 = new Panel();
            DGVweekly = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVweekly).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(AddTaskBtn);
            panel1.Controls.Add(DelTaskBtn);
            panel1.Controls.Add(ToggleBtn);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(754, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 634);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // AddTaskBtn
            // 
            AddTaskBtn.BackColor = Color.DarkGreen;
            AddTaskBtn.Dock = DockStyle.Bottom;
            AddTaskBtn.FlatAppearance.BorderSize = 0;
            AddTaskBtn.FlatStyle = FlatStyle.Flat;
            AddTaskBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            AddTaskBtn.ForeColor = SystemColors.ButtonHighlight;
            AddTaskBtn.Location = new Point(0, 418);
            AddTaskBtn.Margin = new Padding(0);
            AddTaskBtn.Name = "AddTaskBtn";
            AddTaskBtn.Size = new Size(414, 216);
            AddTaskBtn.TabIndex = 2;
            AddTaskBtn.Text = "ADD Weekly Task";
            AddTaskBtn.UseVisualStyleBackColor = false;
            AddTaskBtn.Click += AddTaskBtn_Click;
            // 
            // DelTaskBtn
            // 
            DelTaskBtn.BackColor = Color.Maroon;
            DelTaskBtn.Dock = DockStyle.Top;
            DelTaskBtn.FlatAppearance.BorderSize = 0;
            DelTaskBtn.FlatStyle = FlatStyle.Flat;
            DelTaskBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            DelTaskBtn.ForeColor = SystemColors.ButtonHighlight;
            DelTaskBtn.Location = new Point(0, 158);
            DelTaskBtn.Margin = new Padding(0);
            DelTaskBtn.Name = "DelTaskBtn";
            DelTaskBtn.Size = new Size(414, 87);
            DelTaskBtn.TabIndex = 3;
            DelTaskBtn.Text = "Delete Task";
            DelTaskBtn.UseVisualStyleBackColor = false;
            DelTaskBtn.Click += DelTaskBtn_Click;
            // 
            // ToggleBtn
            // 
            ToggleBtn.BackColor = Color.MidnightBlue;
            ToggleBtn.Dock = DockStyle.Top;
            ToggleBtn.FlatAppearance.BorderSize = 0;
            ToggleBtn.FlatStyle = FlatStyle.Flat;
            ToggleBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            ToggleBtn.ForeColor = SystemColors.ButtonHighlight;
            ToggleBtn.Location = new Point(0, 71);
            ToggleBtn.Margin = new Padding(0);
            ToggleBtn.Name = "ToggleBtn";
            ToggleBtn.Size = new Size(414, 87);
            ToggleBtn.TabIndex = 1;
            ToggleBtn.Text = "Mark as completed";
            ToggleBtn.UseVisualStyleBackColor = false;
            ToggleBtn.Click += ToggleBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(414, 71);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 25F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(87, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 41);
            label1.TabIndex = 0;
            label1.Text = "For Selected Data";
            // 
            // panel2
            // 
            panel2.Controls.Add(TaskInput);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 216);
            panel2.TabIndex = 1;
            // 
            // TaskInput
            // 
            TaskInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TaskInput.Font = new Font("Segoe UI", 20F);
            TaskInput.Location = new Point(12, 34);
            TaskInput.Name = "TaskInput";
            TaskInput.Size = new Size(736, 118);
            TaskInput.TabIndex = 0;
            TaskInput.Text = "";
            // 
            // panel3
            // 
            panel3.Controls.Add(DGVweekly);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(754, 418);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // DGVweekly
            // 
            DGVweekly.BackgroundColor = Color.FromArgb(42, 39, 89);
            DGVweekly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVweekly.Dock = DockStyle.Fill;
            DGVweekly.Location = new Point(0, 0);
            DGVweekly.Name = "DGVweekly";
            DGVweekly.Size = new Size(754, 418);
            DGVweekly.TabIndex = 0;
            DGVweekly.CellContentClick += dataGridView1_CellContentClick;
            DGVweekly.DataBindingComplete += DGVweekly_DataBindingComplete;
            // 
            // Weekly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 18, 43);
            ClientSize = new Size(1168, 634);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Weekly";
            Text = "Weekly";
            Load += WeeklyForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVweekly).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView DGVweekly;
        private RichTextBox TaskInput;
        private Panel panel4;
        private Label label1;
        private Button ToggleBtn;
        private Button AddTaskBtn;
        private Button DelTaskBtn;
    }
}