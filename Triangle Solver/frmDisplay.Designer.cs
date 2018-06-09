namespace Triangle_Solver
{
	partial class frmDisplay
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
			this.pnlDraw = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// pnlDraw
			// 
			this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDraw.Location = new System.Drawing.Point(0, 0);
			this.pnlDraw.Name = "pnlDraw";
			this.pnlDraw.Size = new System.Drawing.Size(484, 461);
			this.pnlDraw.TabIndex = 0;
			this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
			this.pnlDraw.Resize += new System.EventHandler(this.pnlDraw_Resize);
			// 
			// frmDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.pnlDraw);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(50, 50);
			this.Name = "frmDisplay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Triangle Display";
			this.Load += new System.EventHandler(this.frmDisplay_Load);
			this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.frmDisplay_MouseWheel);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlDraw;
	}
}