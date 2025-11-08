namespace PresentationLayer
{
    partial class TheGame
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
            this.components = new System.ComponentModel.Container();
            this.minefieldTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bomb_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minefieldTable
            // 
            this.minefieldTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minefieldTable.AutoSize = true;
            this.minefieldTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minefieldTable.BackColor = System.Drawing.Color.LightSlateGray;
            this.minefieldTable.ColumnCount = 1;
            this.minefieldTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.minefieldTable.Location = new System.Drawing.Point(12, 22);
            this.minefieldTable.Name = "minefieldTable";
            this.minefieldTable.RowCount = 1;
            this.minefieldTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.minefieldTable.Size = new System.Drawing.Size(0, 0);
            this.minefieldTable.TabIndex = 0;
            this.minefieldTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bombs left:";
            // 
            // bomb_lbl
            // 
            this.bomb_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bomb_lbl.AutoSize = true;
            this.bomb_lbl.BackColor = System.Drawing.Color.LightSlateGray;
            this.bomb_lbl.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bomb_lbl.Location = new System.Drawing.Point(167, 64);
            this.bomb_lbl.Name = "bomb_lbl";
            this.bomb_lbl.Size = new System.Drawing.Size(31, 31);
            this.bomb_lbl.TabIndex = 4;
            this.bomb_lbl.Text = "0";
            this.bomb_lbl.TextChanged += new System.EventHandler(this.bomb_lbl_TextChanged);
            this.bomb_lbl.Click += new System.EventHandler(this.bomb_lbl_Click);
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(242, 0);
            this.Controls.Add(this.bomb_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minefieldTable);
            this.Name = "TheGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheGame";
            this.Load += new System.EventHandler(this.TheGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel minefieldTable;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label bomb_lbl;
    }
}