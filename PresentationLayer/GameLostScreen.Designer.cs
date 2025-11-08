namespace PresentationLayer
{
    partial class GameLostScreen
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
            label2 = new Label();
            mainMenu_btn = new Button();
            retry_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(58, 32);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 0;
            label1.Text = "You lost 😞";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.LightSlateGray;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(104, 79);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 1;
            label2.Text = "Try again ?";
            // 
            // mainMenu_btn
            // 
            mainMenu_btn.Anchor = AnchorStyles.None;
            mainMenu_btn.BackColor = Color.LightSlateGray;
            mainMenu_btn.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            mainMenu_btn.Location = new Point(104, 215);
            mainMenu_btn.Name = "mainMenu_btn";
            mainMenu_btn.Size = new Size(160, 44);
            mainMenu_btn.TabIndex = 2;
            mainMenu_btn.Text = "Main Menu";
            mainMenu_btn.UseVisualStyleBackColor = false;
            mainMenu_btn.Click += mainMenu_btn_Click;
            // 
            // retry_btn
            // 
            retry_btn.BackColor = Color.LightSlateGray;
            retry_btn.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point);
            retry_btn.Location = new Point(104, 145);
            retry_btn.Name = "retry_btn";
            retry_btn.Size = new Size(160, 40);
            retry_btn.TabIndex = 3;
            retry_btn.Text = "Retry";
            retry_btn.UseVisualStyleBackColor = false;
            retry_btn.Click += retry_btn_Click;
            // 
            // GameLostScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(368, 271);
            Controls.Add(retry_btn);
            Controls.Add(mainMenu_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GameLostScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameLostScreen";
            Load += GameLostScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button mainMenu_btn;
        private Button retry_btn;
    }
}