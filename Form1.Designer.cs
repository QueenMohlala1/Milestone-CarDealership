namespace Milestone_System
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.maitainCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainatainTechniciansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maitainCustomersToolStripMenuItem,
            this.maintainServicesToolStripMenuItem,
            this.mainatainTechniciansToolStripMenuItem,
            this.maToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1450, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1450, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // maitainCustomersToolStripMenuItem
            // 
            this.maitainCustomersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewCustomersToolStripMenuItem});
            this.maitainCustomersToolStripMenuItem.Name = "maitainCustomersToolStripMenuItem";
            this.maitainCustomersToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.maitainCustomersToolStripMenuItem.Text = "Maitain Customers";
            this.maitainCustomersToolStripMenuItem.Click += new System.EventHandler(this.maitainCustomersToolStripMenuItem_Click);
            // 
            // maintainServicesToolStripMenuItem
            // 
            this.maintainServicesToolStripMenuItem.Name = "maintainServicesToolStripMenuItem";
            this.maintainServicesToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.maintainServicesToolStripMenuItem.Text = "Maintain Services";
            // 
            // mainatainTechniciansToolStripMenuItem
            // 
            this.mainatainTechniciansToolStripMenuItem.Name = "mainatainTechniciansToolStripMenuItem";
            this.mainatainTechniciansToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.mainatainTechniciansToolStripMenuItem.Text = "Mainatain Technicians";
            // 
            // maToolStripMenuItem
            // 
            this.maToolStripMenuItem.Name = "maToolStripMenuItem";
            this.maToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.maToolStripMenuItem.Text = "Maintain Car Parts";
            // 
            // insertNewCustomersToolStripMenuItem
            // 
            this.insertNewCustomersToolStripMenuItem.Name = "insertNewCustomersToolStripMenuItem";
            this.insertNewCustomersToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.insertNewCustomersToolStripMenuItem.Text = "Insert new Customers";
            this.insertNewCustomersToolStripMenuItem.Click += new System.EventHandler(this.insertNewCustomersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maitainCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainatainTechniciansToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem maToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewCustomersToolStripMenuItem;
    }
}

