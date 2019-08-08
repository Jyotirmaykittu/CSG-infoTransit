namespace CsgITLed1._0
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PartialRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DataCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDataCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitPicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.mMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1726, 76);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to CSG ";
            // 
            // mMain
            // 
            this.mMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.ExitPicToolStripMenuItem});
            this.mMain.Location = new System.Drawing.Point(0, 76);
            this.mMain.Name = "mMain";
            this.mMain.Size = new System.Drawing.Size(1726, 33);
            this.mMain.TabIndex = 6;
            this.mMain.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlReportToolStripMenuItem,
            this.sendReportToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // xmlReportToolStripMenuItem
            // 
            this.xmlReportToolStripMenuItem.Name = "xmlReportToolStripMenuItem";
            this.xmlReportToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.xmlReportToolStripMenuItem.Text = "Xml Report";
            this.xmlReportToolStripMenuItem.Click += new System.EventHandler(this.xmlReportToolStripMenuItem_Click);
            // 
            // sendReportToolStripMenuItem
            // 
            this.sendReportToolStripMenuItem.Name = "sendReportToolStripMenuItem";
            this.sendReportToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.sendReportToolStripMenuItem.Text = "Send Report";
            this.sendReportToolStripMenuItem.Click += new System.EventHandler(this.sendReportToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RouteToolStripMenuItem,
            this.StopToolStripMenuItem,
            this.PartialRouteToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 29);
            this.toolStripMenuItem2.Text = "Insert";
            // 
            // RouteToolStripMenuItem
            // 
            this.RouteToolStripMenuItem.Name = "RouteToolStripMenuItem";
            this.RouteToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.RouteToolStripMenuItem.Text = "Stop";
            this.RouteToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.StopToolStripMenuItem.Text = "Route";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.RouteToolStripMenuItem_Click);
            // 
            // PartialRouteToolStripMenuItem
            // 
            this.PartialRouteToolStripMenuItem.Name = "PartialRouteToolStripMenuItem";
            this.PartialRouteToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.PartialRouteToolStripMenuItem.Text = "Partial Route";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataCenterToolStripMenuItem,
            this.newDataCenterToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(81, 29);
            this.toolStripMenuItem3.Text = "Format";
            // 
            // DataCenterToolStripMenuItem
            // 
            this.DataCenterToolStripMenuItem.Name = "DataCenterToolStripMenuItem";
            this.DataCenterToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.DataCenterToolStripMenuItem.Text = "DataCenter";
            this.DataCenterToolStripMenuItem.Click += new System.EventHandler(this.DataCenterToolStripMenuItem_Click);
            // 
            // newDataCenterToolStripMenuItem
            // 
            this.newDataCenterToolStripMenuItem.Name = "newDataCenterToolStripMenuItem";
            this.newDataCenterToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.newDataCenterToolStripMenuItem.Text = "New Data Center ";
            this.newDataCenterToolStripMenuItem.Click += new System.EventHandler(this.newDataCenterToolStripMenuItem_Click);
            // 
            // ExitPicToolStripMenuItem
            // 
            this.ExitPicToolStripMenuItem.Name = "ExitPicToolStripMenuItem";
            this.ExitPicToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.ExitPicToolStripMenuItem.Text = "Exit";
            this.ExitPicToolStripMenuItem.Click += new System.EventHandler(this.ExitPicToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CsgITLed1._0.Properties.Resources.rsz_logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 67);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 596);
            this.Controls.Add(this.mMain);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mMain.ResumeLayout(false);
            this.mMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xmlReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem RouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PartialRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem DataCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitPicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDataCenterToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

