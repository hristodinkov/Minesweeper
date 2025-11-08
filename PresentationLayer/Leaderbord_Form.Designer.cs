namespace PresentationLayer
{
    partial class Leaderbord_Form
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
            Title = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.LightSlateGray;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("MV Boli", 48F, FontStyle.Italic, GraphicsUnit.Point);
            Title.ForeColor = SystemColors.ControlText;
            Title.Location = new Point(71, 9);
            Title.Margin = new Padding(3, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(696, 87);
            Title.TabIndex = 1;
            Title.Text = "💣 Leaderboard 💣  ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(20, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(772, 481);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Font = new Font("MV Boli", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(837, 540);
            button1.Name = "button1";
            button1.Size = new Size(120, 43);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSlateGray;
            textBox1.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(810, 102);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 46);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(810, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 5;
            label1.Text = "USERNAME:";
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(810, 195);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(147, 34);
            button2.TabIndex = 6;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightSlateGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(810, 152);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 39);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Leaderbord_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1032, 602);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Title);
            ForeColor = SystemColors.ControlText;
            Name = "Leaderbord_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leaderbord";
            Load += Leaderbord_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
    }
}