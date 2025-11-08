namespace PresentationLayer
{
    partial class MainMenu
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
            this.Title = new System.Windows.Forms.Label();
            this.play_button = new System.Windows.Forms.Button();
            this.options_button = new System.Windows.Forms.Button();
            this.profiles_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.LightSlateGray;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Title.Location = new System.Drawing.Point(36, 32);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(713, 87);
            this.Title.TabIndex = 0;
            this.Title.Text = "💣 Minesweeper 💣  ";
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.play_button.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.play_button.Location = new System.Drawing.Point(283, 152);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(191, 43);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click_1);
            // 
            // options_button
            // 
            this.options_button.BackColor = System.Drawing.Color.SlateGray;
            this.options_button.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.options_button.Location = new System.Drawing.Point(283, 298);
            this.options_button.Name = "options_button";
            this.options_button.Size = new System.Drawing.Size(191, 43);
            this.options_button.TabIndex = 2;
            this.options_button.Text = "Leaderboard";
            this.options_button.UseVisualStyleBackColor = false;
            this.options_button.Click += new System.EventHandler(this.options_button_Click_1);
            // 
            // profiles_button
            // 
            this.profiles_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.profiles_button.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.profiles_button.Location = new System.Drawing.Point(283, 226);
            this.profiles_button.Name = "profiles_button";
            this.profiles_button.Size = new System.Drawing.Size(191, 43);
            this.profiles_button.TabIndex = 3;
            this.profiles_button.Text = "Profile";
            this.profiles_button.UseVisualStyleBackColor = false;
            this.profiles_button.Click += new System.EventHandler(this.profiles_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.SlateGray;
            this.exit_button.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(283, 372);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(191, 43);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.profiles_button);
            this.Controls.Add(this.options_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.Title);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Button play_button;
        private Button options_button;
        private Button profiles_button;
        private Button exit_button;
    }
}