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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLowerThird.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.Navy;
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.Cyan;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 571);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLowerThird
            // 
            this.panelLowerThird.BackColor = System.Drawing.Color.Navy;
            this.panelLowerThird.Controls.Add(this.textBox1);
            this.panelLowerThird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLowerThird.Location = new System.Drawing.Point(200, 521);
            this.panelLowerThird.Name = "panelLowerThird";
            this.panelLowerThird.Size = new System.Drawing.Size(836, 50);
            this.panelLowerThird.TabIndex = 1;
            this.panelLowerThird.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLowerThird_Paint);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenu.Location = new System.Drawing.Point(200, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(836, 522);
            this.panelMainMenu.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(836, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "©2020 Hewwo uwu";
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
            this.panelLowerThird.ResumeLayout(false);
            this.panelLowerThird.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLowerThird;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.TextBox textBox1;
    }
}

