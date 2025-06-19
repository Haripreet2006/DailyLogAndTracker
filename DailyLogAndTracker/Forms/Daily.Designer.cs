namespace DailyLogAndTracker
{
    partial class Daily
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
            DGVout = new DataGridView();
            panel2 = new Panel();
            AddBtn = new Button();
            DelBtn = new Button();
            TextInp = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVout).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DGVout);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 633);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // DGVout
            // 
            DGVout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVout.BackgroundColor = Color.FromArgb(42, 39, 89);
            DGVout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVout.Location = new Point(44, 22);
            DGVout.Name = "DGVout";
            DGVout.Size = new Size(1081, 413);
            DGVout.TabIndex = 0;
            DGVout.CellContentClick += dataGridView1_CellContentClick;
            DGVout.DataBindingComplete += DGVout_DataBindingComplete;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(DelBtn);
            panel2.Controls.Add(TextInp);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 180);
            panel2.TabIndex = 1;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkGreen;
            AddBtn.Dock = DockStyle.Right;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            AddBtn.ForeColor = SystemColors.ButtonFace;
            AddBtn.Location = new Point(589, 0);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(284, 180);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.Maroon;
            DelBtn.Dock = DockStyle.Right;
            DelBtn.FlatAppearance.BorderSize = 0;
            DelBtn.FlatStyle = FlatStyle.Flat;
            DelBtn.Font = new Font("Bahnschrift SemiCondensed", 20.25F);
            DelBtn.ForeColor = SystemColors.ButtonHighlight;
            DelBtn.Location = new Point(873, 0);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(284, 180);
            DelBtn.TabIndex = 1;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // TextInp
            // 
            TextInp.Dock = DockStyle.Fill;
            TextInp.Font = new Font("Segoe UI", 25F);
            TextInp.Location = new Point(0, 0);
            TextInp.Name = "TextInp";
            TextInp.Size = new Size(1157, 180);
            TextInp.TabIndex = 0;
            TextInp.Text = "";
            TextInp.TextChanged += TextInp_TextChanged;
            // 
            // Daily
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 18, 43);
            ClientSize = new Size(1157, 633);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Daily";
            Text = "Daily";
            Load += Daily_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVout).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RichTextBox TextInp;
        private DataGridView DGVout;
        private Button DelBtn;
        private Button AddBtn;
    }
}