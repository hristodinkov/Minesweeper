namespace PresentationLayer
{
    partial class Sign_up
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.LightSlateGray;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("MV Boli", 24F, FontStyle.Italic, GraphicsUnit.Point);
            Title.ForeColor = SystemColors.ControlText;
            Title.Location = new Point(24, 30);
            Title.Margin = new Padding(3, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(348, 43);
            Title.TabIndex = 3;
            Title.Text = "💣 Minesweeper 💣  ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSlateGray;
            textBox1.Font = new Font("MV Boli", 17F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(66, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 44);
            textBox1.TabIndex = 4;
            textBox1.Text = "Enter your username:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSlateGray;
            textBox2.Font = new Font("MV Boli", 17F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(66, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 44);
            textBox2.TabIndex = 5;
            textBox2.Text = "Enter your password:";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Location = new Point(66, 253);
            button1.Name = "button1";
            button1.Size = new Size(86, 44);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSlateGray;
            button2.Location = new Point(204, 256);
            button2.Name = "button2";
            button2.Size = new Size(110, 41);
            button2.TabIndex = 7;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(406, 334);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Title);
            Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Sign_up";
            Text = "Sign_up";
            Load += Sign_up_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}