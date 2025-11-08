namespace PresentationLayer
{
    partial class Log_In
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Title = new Label();
            logIn_btn = new Button();
            back_btn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSlateGray;
            textBox1.Location = new Point(65, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 56);
            textBox1.TabIndex = 0;
            textBox1.Text = "Enter your username:";
            textBox1.MouseClick += textBox1_MouseClick;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSlateGray;
            textBox2.Location = new Point(65, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 56);
            textBox2.TabIndex = 1;
            textBox2.Text = "Enter your password:";
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.LightSlateGray;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("MV Boli", 24F, FontStyle.Italic, GraphicsUnit.Point);
            Title.ForeColor = SystemColors.ControlText;
            Title.Location = new Point(-3, 27);
            Title.Margin = new Padding(3, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(449, 54);
            Title.TabIndex = 2;
            Title.Text = "💣 Minesweeper 💣  ";
            Title.Click += Title_Click;
            // 
            // logIn_btn
            // 
            logIn_btn.BackColor = Color.LightSlateGray;
            logIn_btn.Location = new Point(250, 236);
            logIn_btn.Name = "logIn_btn";
            logIn_btn.Size = new Size(104, 48);
            logIn_btn.TabIndex = 3;
            logIn_btn.Text = "Log in";
            logIn_btn.UseVisualStyleBackColor = false;
            logIn_btn.Click += logIn_btn_Click;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.LightSlateGray;
            back_btn.Location = new Point(33, 236);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(92, 48);
            back_btn.TabIndex = 4;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(18F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(366, 296);
            Controls.Add(back_btn);
            Controls.Add(logIn_btn);
            Controls.Add(Title);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Log_In";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log_In";
            Load += Log_In_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label Title;
        private Button logIn_btn;
        private Button back_btn;
    }
}