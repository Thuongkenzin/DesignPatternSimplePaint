namespace FigureDraw
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
            this.panelcontrol = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eclipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gdiPlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cairoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataFlowDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBlockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputBlockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.starToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontrol
            // 
            this.panelcontrol.BackColor = System.Drawing.Color.Transparent;
            this.panelcontrol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontrol.Location = new System.Drawing.Point(0, 24);
            this.panelcontrol.Name = "panelcontrol";
            this.panelcontrol.Size = new System.Drawing.Size(638, 334);
            this.panelcontrol.TabIndex = 0;
            this.panelcontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelcontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelcontrol_MouseDown);
            this.panelcontrol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelcontrol_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.drawToolStripMenuItem,
            this.wadToolStripMenuItem,
            this.diagramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveJpegToolStripMenuItem,
            this.savePngToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Save";
            // 
            // saveJpegToolStripMenuItem
            // 
            this.saveJpegToolStripMenuItem.Name = "saveJpegToolStripMenuItem";
            this.saveJpegToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveJpegToolStripMenuItem.Text = "Save Jpeg";
            this.saveJpegToolStripMenuItem.Click += new System.EventHandler(this.saveJpegToolStripMenuItem_Click);
            // 
            // savePngToolStripMenuItem
            // 
            this.savePngToolStripMenuItem.Name = "savePngToolStripMenuItem";
            this.savePngToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.savePngToolStripMenuItem.Text = "Save Png";
            this.savePngToolStripMenuItem.Click += new System.EventHandler(this.savePngToolStripMenuItem_Click);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.eclipseToolStripMenuItem,
            this.starToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.drawToolStripMenuItem.Text = "Draw";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // eclipseToolStripMenuItem
            // 
            this.eclipseToolStripMenuItem.Name = "eclipseToolStripMenuItem";
            this.eclipseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eclipseToolStripMenuItem.Text = "Eclipse";
            this.eclipseToolStripMenuItem.Click += new System.EventHandler(this.eclipseToolStripMenuItem_Click);
            // 
            // wadToolStripMenuItem
            // 
            this.wadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gdiPlusToolStripMenuItem,
            this.cairoToolStripMenuItem});
            this.wadToolStripMenuItem.Name = "wadToolStripMenuItem";
            this.wadToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.wadToolStripMenuItem.Text = "Graphics";
            // 
            // gdiPlusToolStripMenuItem
            // 
            this.gdiPlusToolStripMenuItem.Name = "gdiPlusToolStripMenuItem";
            this.gdiPlusToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.gdiPlusToolStripMenuItem.Text = "GdiPlus";
            this.gdiPlusToolStripMenuItem.Click += new System.EventHandler(this.gdiPlusToolStripMenuItem_Click);
            // 
            // cairoToolStripMenuItem
            // 
            this.cairoToolStripMenuItem.Name = "cairoToolStripMenuItem";
            this.cairoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.cairoToolStripMenuItem.Text = "Cairo";
            this.cairoToolStripMenuItem.Click += new System.EventHandler(this.cairoToolStripMenuItem_Click);
            // 
            // diagramToolStripMenuItem
            // 
            this.diagramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataFlowDiagramToolStripMenuItem,
            this.flowChartToolStripMenuItem});
            this.diagramToolStripMenuItem.Name = "diagramToolStripMenuItem";
            this.diagramToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.diagramToolStripMenuItem.Text = "Diagram";
            // 
            // dataFlowDiagramToolStripMenuItem
            // 
            this.dataFlowDiagramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startBlockToolStripMenuItem,
            this.inputBlockToolStripMenuItem});
            this.dataFlowDiagramToolStripMenuItem.Name = "dataFlowDiagramToolStripMenuItem";
            this.dataFlowDiagramToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dataFlowDiagramToolStripMenuItem.Text = "Data flow diagram";
            // 
            // startBlockToolStripMenuItem
            // 
            this.startBlockToolStripMenuItem.Name = "startBlockToolStripMenuItem";
            this.startBlockToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.startBlockToolStripMenuItem.Text = "StartBlock";
            this.startBlockToolStripMenuItem.Click += new System.EventHandler(this.startBlockToolStripMenuItem_Click);
            // 
            // inputBlockToolStripMenuItem
            // 
            this.inputBlockToolStripMenuItem.Name = "inputBlockToolStripMenuItem";
            this.inputBlockToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.inputBlockToolStripMenuItem.Text = "InputBlock";
            this.inputBlockToolStripMenuItem.Click += new System.EventHandler(this.inputBlockToolStripMenuItem_Click);
            // 
            // flowChartToolStripMenuItem
            // 
            this.flowChartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startBlockToolStripMenuItem1,
            this.inputBlockToolStripMenuItem1});
            this.flowChartToolStripMenuItem.Name = "flowChartToolStripMenuItem";
            this.flowChartToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.flowChartToolStripMenuItem.Text = "Flow chart";
            // 
            // startBlockToolStripMenuItem1
            // 
            this.startBlockToolStripMenuItem1.Name = "startBlockToolStripMenuItem1";
            this.startBlockToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.startBlockToolStripMenuItem1.Text = "StartBlock";
            this.startBlockToolStripMenuItem1.Click += new System.EventHandler(this.startBlockToolStripMenuItem1_Click);
            // 
            // inputBlockToolStripMenuItem1
            // 
            this.inputBlockToolStripMenuItem1.Name = "inputBlockToolStripMenuItem1";
            this.inputBlockToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.inputBlockToolStripMenuItem1.Text = "InputBlock";
            this.inputBlockToolStripMenuItem1.Click += new System.EventHandler(this.inputBlockToolStripMenuItem1_Click);
            // 
            // starToolStripMenuItem
            // 
            this.starToolStripMenuItem.Name = "starToolStripMenuItem";
            this.starToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.starToolStripMenuItem.Text = "Star";
            this.starToolStripMenuItem.Click += new System.EventHandler(this.starToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 358);
            this.Controls.Add(this.panelcontrol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FigureDraw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcontrol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gdiPlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cairoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eclipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJpegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataFlowDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startBlockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inputBlockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem starToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

