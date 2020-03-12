namespace Plague.inc_STEAMA
{
    partial class Form1
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLowerThird = new System.Windows.Forms.Panel();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.browseButtonPopulasi = new System.Windows.Forms.Button();
            this.textBoxPopulasi = new System.Windows.Forms.TextBox();
            this.browseButtonPeta = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxHari = new System.Windows.Forms.TextBox();
            this.textBoxPeta = new System.Windows.Forms.TextBox();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.Cyan;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 571);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // panelLowerThird
            // 
            this.panelLowerThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelLowerThird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLowerThird.Location = new System.Drawing.Point(200, 521);
            this.panelLowerThird.Name = "panelLowerThird";
            this.panelLowerThird.Size = new System.Drawing.Size(836, 50);
            this.panelLowerThird.TabIndex = 1;
            this.panelLowerThird.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLowerThird_Paint);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Black;
            this.panelMainMenu.Controls.Add(this.resetButton);
            this.panelMainMenu.Controls.Add(this.browseButtonPopulasi);
            this.panelMainMenu.Controls.Add(this.textBoxPopulasi);
            this.panelMainMenu.Controls.Add(this.browseButtonPeta);
            this.panelMainMenu.Controls.Add(this.startButton);
            this.panelMainMenu.Controls.Add(this.textBoxHari);
            this.panelMainMenu.Controls.Add(this.textBoxPeta);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenu.Location = new System.Drawing.Point(200, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(836, 522);
            this.panelMainMenu.TabIndex = 2;
            this.panelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainMenu_Paint);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(191, 386);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(125, 51);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // browseButtonPopulasi
            // 
            this.browseButtonPopulasi.Location = new System.Drawing.Point(590, 91);
            this.browseButtonPopulasi.Name = "browseButtonPopulasi";
            this.browseButtonPopulasi.Size = new System.Drawing.Size(75, 23);
            this.browseButtonPopulasi.TabIndex = 6;
            this.browseButtonPopulasi.Text = "Browse";
            this.browseButtonPopulasi.UseVisualStyleBackColor = true;
            this.browseButtonPopulasi.Click += new System.EventHandler(this.browseButtonPopulasi_Click);
            // 
            // textBoxPopulasi
            // 
            this.textBoxPopulasi.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPopulasi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPopulasi.Location = new System.Drawing.Point(60, 92);
            this.textBoxPopulasi.Name = "textBoxPopulasi";
            this.textBoxPopulasi.ReadOnly = true;
            this.textBoxPopulasi.Size = new System.Drawing.Size(524, 22);
            this.textBoxPopulasi.TabIndex = 5;
            this.textBoxPopulasi.Text = "File Populasi";
            // 
            // browseButtonPeta
            // 
            this.browseButtonPeta.Location = new System.Drawing.Point(590, 63);
            this.browseButtonPeta.Name = "browseButtonPeta";
            this.browseButtonPeta.Size = new System.Drawing.Size(75, 23);
            this.browseButtonPeta.TabIndex = 4;
            this.browseButtonPeta.Text = "Browse";
            this.browseButtonPeta.UseVisualStyleBackColor = true;
            this.browseButtonPeta.Click += new System.EventHandler(this.browseButtonPeta_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(60, 386);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(125, 51);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxHari
            // 
            this.textBoxHari.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHari.Location = new System.Drawing.Point(60, 130);
            this.textBoxHari.Name = "textBoxHari";
            this.textBoxHari.Size = new System.Drawing.Size(524, 22);
            this.textBoxHari.TabIndex = 1;
            this.textBoxHari.Text = "Hari Infeksi ke:";
            this.textBoxHari.Click += new System.EventHandler(this.textBoxHari_Click);
            this.textBoxHari.TextChanged += new System.EventHandler(this.textBoxHari_TextChanged);
            // 
            // textBoxPeta
            // 
            this.textBoxPeta.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPeta.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPeta.Location = new System.Drawing.Point(60, 64);
            this.textBoxPeta.Name = "textBoxPeta";
            this.textBoxPeta.ReadOnly = true;
            this.textBoxPeta.Size = new System.Drawing.Size(524, 22);
            this.textBoxPeta.TabIndex = 0;
            this.textBoxPeta.Text = "File Peta";
            this.textBoxPeta.TextChanged += new System.EventHandler(this.textBoxPeta_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 571);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelLowerThird);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Plague .inc - STEAMA ver.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLowerThird;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBoxHari;
        private System.Windows.Forms.TextBox textBoxPeta;
        private System.Windows.Forms.Button browseButtonPeta;
        private System.Windows.Forms.Button browseButtonPopulasi;
        private System.Windows.Forms.TextBox textBoxPopulasi;
        private System.Windows.Forms.Button resetButton;
    }
}

