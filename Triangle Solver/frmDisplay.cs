using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Triangle_Solver
{
	public partial class frmDisplay : Form
	{
		Bitmap myBitmap;
		float rotation;
		private frmMain frm;
		public frmDisplay()
		{
			InitializeComponent();
		}

		public frmDisplay(frmMain frm)
		{
			InitializeComponent();
			this.frm = frm;
		}

		private void frmDisplay_Load(object sender, EventArgs e)
		{
			
			this.Icon = frm.Icon;
			rotation = 0;
			if (frm.DrawingData != null)
			{
				myBitmap = frm.DrawingData.Draw(pnlDraw.Height);
			}
		}

		private void pnlDraw_Paint(object sender, PaintEventArgs e)
		{
			using (Matrix m = new Matrix())
			{
				m.RotateAt(rotation, new PointF(myBitmap.Width / 2, myBitmap.Height / 2));
				e.Graphics.Transform = m;
			}
			e.Graphics.DrawImage(myBitmap, 1, 1);
			e.Graphics.ResetTransform();
		}

		private void pnlDraw_Resize(object sender, EventArgs e)
		{
			
			if (frm.DrawingData != null) myBitmap = frm.DrawingData.Draw(Math.Max(pnlDraw.Height, pnlDraw.Width) - 20);
			this.Refresh();
		}

		private void frmDisplay_MouseWheel(object sender, MouseEventArgs e)
		{
			rotation += e.Delta / 15;
			this.Refresh();
		}
	}
}
