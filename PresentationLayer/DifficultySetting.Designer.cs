namespace PresentationLayer
{
    partial class DifficultySetting
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
            label1 = new Label();
            easy_btn = new Button();
            medium_btn = new Button();
            hard_btn = new Button();
            huge_btn = new Button();
            extreme_btn = new Button();
            custom_lbl = new Label();
            x_square = new NumericUpDown();
            y_squares = new NumericUpDown();
            bombs_counter = new NumericUpDown();
            rows_lbl = new Label();
            column_lbl = new Label();
            bomb_lbl = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)x_square).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y_squares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bombs_counter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("MV Boli", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(135, 19);
            label1.Name = "label1";
            label1.Size = new Size(511, 85);
            label1.TabIndex = 0;
            label1.Text = "Select difficulty";
            label1.Click += label1_Click;
            // 
            // easy_btn
            // 
            easy_btn.BackColor = Color.LightSlateGray;
            easy_btn.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            easy_btn.Location = new Point(51, 132);
            easy_btn.Name = "easy_btn";
            easy_btn.Size = new Size(143, 43);
            easy_btn.TabIndex = 1;
            easy_btn.Text = "Easy";
            easy_btn.UseVisualStyleBackColor = false;
            easy_btn.Click += easy_btn_Click;
            // 
            // medium_btn
            // 
            medium_btn.BackColor = Color.LightSlateGray;
            medium_btn.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            medium_btn.Location = new Point(51, 195);
            medium_btn.Name = "medium_btn";
            medium_btn.Size = new Size(143, 41);
            medium_btn.TabIndex = 2;
            medium_btn.Text = "Medium";
            medium_btn.UseVisualStyleBackColor = false;
            medium_btn.Click += medium_btn_Click;
            // 
            // hard_btn
            // 
            hard_btn.BackColor = Color.LightSlateGray;
            hard_btn.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            hard_btn.Location = new Point(51, 268);
            hard_btn.Name = "hard_btn";
            hard_btn.Size = new Size(143, 43);
            hard_btn.TabIndex = 3;
            hard_btn.Text = "Hard";
            hard_btn.UseVisualStyleBackColor = false;
            hard_btn.Click += hard_btn_Click;
            // 
            // huge_btn
            // 
            huge_btn.BackColor = Color.LightSlateGray;
            huge_btn.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            huge_btn.Location = new Point(51, 331);
            huge_btn.Name = "huge_btn";
            huge_btn.Size = new Size(143, 40);
            huge_btn.TabIndex = 4;
            huge_btn.Text = "Huge";
            huge_btn.UseVisualStyleBackColor = false;
            huge_btn.Click += huge_btn_Click;
            // 
            // extreme_btn
            // 
            extreme_btn.BackColor = Color.LightSlateGray;
            extreme_btn.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            extreme_btn.Location = new Point(51, 397);
            extreme_btn.Name = "extreme_btn";
            extreme_btn.Size = new Size(143, 41);
            extreme_btn.TabIndex = 5;
            extreme_btn.Text = "Extreme";
            extreme_btn.UseVisualStyleBackColor = false;
            extreme_btn.Click += extreme_btn_Click;
            // 
            // custom_lbl
            // 
            custom_lbl.AutoSize = true;
            custom_lbl.BackColor = Color.LightSlateGray;
            custom_lbl.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            custom_lbl.Location = new Point(434, 132);
            custom_lbl.Name = "custom_lbl";
            custom_lbl.Size = new Size(98, 31);
            custom_lbl.TabIndex = 6;
            custom_lbl.Text = "Custom";
            custom_lbl.Click += custom_lbl_Click;
            // 
            // x_square
            // 
            x_square.BackColor = Color.LightSlateGray;
            x_square.Location = new Point(340, 239);
            x_square.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            x_square.Name = "x_square";
            x_square.Size = new Size(77, 23);
            x_square.TabIndex = 7;
            x_square.Value = new decimal(new int[] { 2, 0, 0, 0 });
            x_square.ValueChanged += x_square_ValueChanged;
            // 
            // y_squares
            // 
            y_squares.BackColor = Color.LightSlateGray;
            y_squares.Location = new Point(453, 239);
            y_squares.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            y_squares.Name = "y_squares";
            y_squares.Size = new Size(79, 23);
            y_squares.TabIndex = 8;
            y_squares.Value = new decimal(new int[] { 2, 0, 0, 0 });
            y_squares.ValueChanged += y_squares_ValueChanged;
            // 
            // bombs_counter
            // 
            bombs_counter.BackColor = Color.LightSlateGray;
            bombs_counter.Location = new Point(578, 239);
            bombs_counter.Maximum = new decimal(new int[] { 79, 0, 0, 0 });
            bombs_counter.Name = "bombs_counter";
            bombs_counter.Size = new Size(68, 23);
            bombs_counter.TabIndex = 9;
            bombs_counter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            bombs_counter.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // rows_lbl
            // 
            rows_lbl.AutoSize = true;
            rows_lbl.BackColor = Color.LightSlateGray;
            rows_lbl.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            rows_lbl.Location = new Point(340, 184);
            rows_lbl.Name = "rows_lbl";
            rows_lbl.Size = new Size(72, 31);
            rows_lbl.TabIndex = 10;
            rows_lbl.Text = "Rows";
            // 
            // column_lbl
            // 
            column_lbl.AutoSize = true;
            column_lbl.BackColor = Color.LightSlateGray;
            column_lbl.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            column_lbl.Location = new Point(438, 184);
            column_lbl.Name = "column_lbl";
            column_lbl.Size = new Size(104, 31);
            column_lbl.TabIndex = 11;
            column_lbl.Text = "Columns";
            // 
            // bomb_lbl
            // 
            bomb_lbl.AutoSize = true;
            bomb_lbl.BackColor = Color.LightSlateGray;
            bomb_lbl.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            bomb_lbl.Location = new Point(569, 184);
            bomb_lbl.Name = "bomb_lbl";
            bomb_lbl.Size = new Size(86, 31);
            bomb_lbl.TabIndex = 12;
            bomb_lbl.Text = "Bombs";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(649, 331);
            button1.Name = "button1";
            button1.Size = new Size(91, 48);
            button1.TabIndex = 13;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DifficultySetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bomb_lbl);
            Controls.Add(column_lbl);
            Controls.Add(rows_lbl);
            Controls.Add(bombs_counter);
            Controls.Add(y_squares);
            Controls.Add(x_square);
            Controls.Add(custom_lbl);
            Controls.Add(extreme_btn);
            Controls.Add(huge_btn);
            Controls.Add(hard_btn);
            Controls.Add(medium_btn);
            Controls.Add(easy_btn);
            Controls.Add(label1);
            Name = "DifficultySetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DifficultySetting";
            Load += DifficultySetting_Load;
            ((System.ComponentModel.ISupportInitialize)x_square).EndInit();
            ((System.ComponentModel.ISupportInitialize)y_squares).EndInit();
            ((System.ComponentModel.ISupportInitialize)bombs_counter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button easy_btn;
        private Button medium_btn;
        private Button hard_btn;
        private Button huge_btn;
        private Button extreme_btn;
        private Label custom_lbl;
        private NumericUpDown x_square;
        private NumericUpDown y_squares;
        private NumericUpDown bombs_counter;
        private Label rows_lbl;
        private Label column_lbl;
        private Label bomb_lbl;
        private Button button1;
    }
}