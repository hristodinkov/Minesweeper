namespace PresentationLayer
{
    partial class Profiles
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
            logIn_btn = new Button();
            signUp_btn = new Button();
            label1 = new Label();
            label2 = new Label();
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
            Title.Location = new Point(-2, 21);
            Title.Margin = new Padding(3, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(449, 54);
            Title.TabIndex = 1;
            Title.Text = "💣 Minesweeper 💣  ";
            // 
            // logIn_btn
            // 
            logIn_btn.BackColor = Color.LightSlateGray;
            logIn_btn.Location = new Point(131, 96);
            logIn_btn.Name = "logIn_btn";
            logIn_btn.Size = new Size(145, 51);
            logIn_btn.TabIndex = 2;
            logIn_btn.Text = "Log in";
            logIn_btn.UseVisualStyleBackColor = false;
            logIn_btn.Click += logIn_btn_Click;
            // 
            // signUp_btn
            // 
            signUp_btn.BackColor = Color.LightSlateGray;
            signUp_btn.Location = new Point(131, 165);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(145, 55);
            signUp_btn.TabIndex = 3;
            signUp_btn.Text = "Sign up";
            signUp_btn.UseVisualStyleBackColor = false;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(-2, 318);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 4;
            label1.Text = "Current profile:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSlateGray;
            label2.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(185, 318);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 5;
            label2.Text = "Guest";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Font = new Font("MV Boli", 14F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(274, 298);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 6;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSlateGray;
            button2.Location = new Point(59, 226);
            button2.Name = "button2";
            button2.Size = new Size(287, 52);
            button2.TabIndex = 7;
            button2.Text = "Continue as Guest";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Profiles
            // 
            AutoScaleDimensions = new SizeF(18F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(400, 349);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUp_btn);
            Controls.Add(logIn_btn);
            Controls.Add(Title);
            Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Profiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profiles";
            Load += Profiles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button logIn_btn;
        private Button signUp_btn;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}