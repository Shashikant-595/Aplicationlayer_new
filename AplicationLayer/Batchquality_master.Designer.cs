namespace AplicationLayer
{
    partial class Batchquality_master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batchquality_master));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rheoMooneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rheoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mooneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rheoMooneyToolStripMenuItem,
            this.rheoToolStripMenuItem,
            this.mooneyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rheoMooneyToolStripMenuItem
            // 
            this.rheoMooneyToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rheoMooneyToolStripMenuItem.Name = "rheoMooneyToolStripMenuItem";
            this.rheoMooneyToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.rheoMooneyToolStripMenuItem.Text = "Rheo&Mooney";
            this.rheoMooneyToolStripMenuItem.Click += new System.EventHandler(this.rheoMooneyToolStripMenuItem_Click);
            // 
            // rheoToolStripMenuItem
            // 
            this.rheoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rheoToolStripMenuItem.Name = "rheoToolStripMenuItem";
            this.rheoToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.rheoToolStripMenuItem.Text = "Rheo";
            this.rheoToolStripMenuItem.Click += new System.EventHandler(this.rheoToolStripMenuItem_Click);
            // 
            // mooneyToolStripMenuItem
            // 
            this.mooneyToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mooneyToolStripMenuItem.Name = "mooneyToolStripMenuItem";
            this.mooneyToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.mooneyToolStripMenuItem.Text = "Mooney";
            this.mooneyToolStripMenuItem.Click += new System.EventHandler(this.mooneyToolStripMenuItem_Click);
            // 
            // Batchquality_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1253, 638);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Batchquality_master";
            this.Tag = "";
            this.Text = "Mixing Quality Master ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Batchquality_master_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rheoMooneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rheoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mooneyToolStripMenuItem;
    }
}