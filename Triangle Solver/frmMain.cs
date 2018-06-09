using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triangle_Solver
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
		public TriangleData DrawingData;
		public Bases Base;
		public Bitmap bitmap;

        private void Form1_Load(object sender, EventArgs e)
        {
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			cmbType.SelectedIndex = 0;
        }

		private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			disableall();
			switch (cmbType.SelectedIndex)
			{
				case 0:
					txtAB.ReadOnly = false;
					txtBC.ReadOnly = false;
					txtAC.ReadOnly = false;
					break;
				case 1:
					txtAB.ReadOnly = false;
					txtBC.ReadOnly = false;
					txtA.ReadOnly = false;
					break;
				case 2:
					txtAB.ReadOnly = false;
					txtBC.ReadOnly = false;
					txtB.ReadOnly = false;
					break;
				case 3:
					txtAB.ReadOnly = false;
					txtBC.ReadOnly = false;
					txtC.ReadOnly = false;
					break;
				case 4:
					txtBC.ReadOnly = false;
					txtAC.ReadOnly = false;
					txtA.ReadOnly = false;
					break;
				case 5:
					txtBC.ReadOnly = false;
					txtAC.ReadOnly = false;
					txtB.ReadOnly = false;
					break;
				case 6:
					txtBC.ReadOnly = false;
					txtAC.ReadOnly = false;
					txtC.ReadOnly = false;
					break;
				case 7:
					txtAC.ReadOnly = false;
					txtAB.ReadOnly = false;
					txtA.ReadOnly = false;
					break;
				case 8:
					txtAC.ReadOnly = false;
					txtAB.ReadOnly = false;
					txtB.ReadOnly = false;
					break;
				case 9:
					txtAC.ReadOnly = false;
					txtAB.ReadOnly = false;
					txtC.ReadOnly = false;
					break;
				case 10:
					txtAB.ReadOnly = false;
					txtA.ReadOnly = false;
					txtB.ReadOnly = false;
					break;
				case 11:
					txtAB.ReadOnly = false;
					txtB.ReadOnly = false;
					txtC.ReadOnly = false;
					break;
				case 12:
					txtAB.ReadOnly = false;
					txtC.ReadOnly = false;
					txtA.ReadOnly = false;
					break;
				case 13:
					txtBC.ReadOnly = false;
					txtA.ReadOnly = false;
					txtB.ReadOnly = false;
					break;
				case 14:
					txtBC.ReadOnly = false;
					txtB.ReadOnly = false;
					txtC.ReadOnly = false;
					break;
				case 15:
					txtBC.ReadOnly = false;
					txtC.ReadOnly = false;
					txtA.ReadOnly = false;
					break;
				case 16:
					txtAC.ReadOnly = false;
					txtA.ReadOnly = false;
					txtB.ReadOnly = false;
					break;
				case 17:
					txtAC.ReadOnly = false;
					txtB.ReadOnly = false;
					txtC.ReadOnly = false;
					break;
				case 18:
					txtAC.ReadOnly = false;
					txtC.ReadOnly = false;
					txtA.ReadOnly = false;
					break;
			}
		}
		private void disableall()
		{
			txtAB.Text = "";
			txtBC.Text = "";
			txtAC.Text = "";
			txtA.Text = "";
			txtB.Text = "";
			txtC.Text = "";
			txtPerimeter.Text = "";
			txtArea.Text = "";
			txtAltidudeAB.Text = "";
			txtAltidudeBC.Text = "";
			txtAltidudeAC.Text = "";
			txtAB.ReadOnly = true;
			txtBC.ReadOnly = true;
			txtAC.ReadOnly = true;
			txtA.ReadOnly = true;
			txtB.ReadOnly = true;
			txtC.ReadOnly = true;
		}
		private void txts_TextChanged(object sender, EventArgs e)
		{
			int Count = 0;
			if (((txtA.ReadOnly == false) && (Parse(txtA.Text) > 0))) Count++;
			if (((txtB.ReadOnly == false) && (Parse(txtB.Text) > 0))) Count++;
			if (((txtC.ReadOnly == false) && (Parse(txtC.Text) > 0))) Count++;
			if (((txtAB.ReadOnly == false) && (Parse(txtAB.Text) > 0))) Count++;
			if (((txtBC.ReadOnly == false) && (Parse(txtBC.Text) > 0))) Count++;
			if (((txtAC.ReadOnly == false) && (Parse(txtAC.Text) > 0))) Count++;

			if ((Count == 3))
			{
				btnCalculate.Enabled = true;
			}
			else
			{
				btnCalculate.Enabled = false;
			}
		}
		private float Parse(string expression)
		{
			float result=0;
			float.TryParse(expression, out result);
			return result;
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			TriangleCalculator calc;
			float _AB, _BC, _AC, _A, _B, _C;
			_AB = (!txtAB.ReadOnly) ? Parse(txtAB.Text) : 0;
			_BC = (!txtBC.ReadOnly) ? Parse(txtBC.Text) : 0;
			_AC = (!txtAC.ReadOnly) ? Parse(txtAC.Text) : 0;
			_A = (!txtA.ReadOnly) ? Parse(txtA.Text) : 0;
			_B = (!txtB.ReadOnly) ? Parse(txtB.Text) : 0;
			_C = (!txtC.ReadOnly) ? Parse(txtC.Text) : 0;

			txtAB.Text = (_AB != 0) ? _AB.ToString() : "";
			txtBC.Text = (_BC != 0) ? _BC.ToString() : "";
			txtAC.Text = (_AC != 0) ? _AC.ToString() : "";
			txtA.Text = (_A != 0) ? _A.ToString() : "";
			txtB.Text = (_B != 0) ? _B.ToString() : "";
			txtC.Text = (_C != 0) ? _C.ToString() : "";

			try
			{
				switch (cmbType.SelectedIndex)
				{
					case 1:
						calc= new TriangleCalculator(ItemsType.AB_BC_A, _AB, _BC, _A);
						break;
					case 2:
						calc= new TriangleCalculator(ItemsType.AB_BC_B, _AB, _BC, _B);
						break;
					case 3:
						calc= new TriangleCalculator(ItemsType.AB_BC_C, _AB, _BC, _C);
						break;
					case 4:
						calc= new TriangleCalculator(ItemsType.BC_AC_A, _BC, _AC, _A);
						break;
					case 5:
						calc= new TriangleCalculator(ItemsType.BC_AC_B, _BC, _AC, _B);
						break;
					case 6:
						calc= new TriangleCalculator(ItemsType.BC_AC_C, _BC, _AC, _C);
						break;
					case 7:
						calc= new TriangleCalculator(ItemsType.AB_AC_A, _AB, _AC, _A);
						break;
					case 8:
						calc= new TriangleCalculator(ItemsType.AB_AC_B, _AB, _AC, _B);
						break;
					case 9:
						calc= new TriangleCalculator(ItemsType.AB_AC_C, _AB, _AC, _C);
						break;
					case 10:
						calc= new TriangleCalculator(ItemsType.AB_A_B, _AB, _A, _B);
						break;
					case 11:
						calc= new TriangleCalculator(ItemsType.AB_B_C, _AB, _B, _C);
						break;
					case 12:
						calc= new TriangleCalculator(ItemsType.AB_A_C, _AB, _A, _C);
						break;
					case 13:
						calc= new TriangleCalculator(ItemsType.BC_A_B, _BC, _A, _B);
						break;
					case 14:
						calc= new TriangleCalculator(ItemsType.BC_B_C, _BC, _B, _C);
						break;
					case 15:
						calc= new TriangleCalculator(ItemsType.BC_A_C, _BC, _A, _C);
						break;
					case 16:
						calc= new TriangleCalculator(ItemsType.AC_A_B, _AC, _A, _B);
						break;
					case 17:
						calc= new TriangleCalculator(ItemsType.AC_B_C, _AC, _B, _C);
						break;
					case 18:
						calc= new TriangleCalculator(ItemsType.AC_A_C, _AC, _A, _C);
						break;
					default:
						calc= new TriangleCalculator(ItemsType.AB_BC_AC, _AB, _BC, _AC);
						break;
				}
				calc.AmbigiousObtuse = chkAmbigious.Checked;
				calc.CalculateTriangle();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this,ex.Message,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			txtA.Text = Math.Round(calc.AngleA, Convert.ToInt32(numDigits.Value)).ToString();
			txtAB.Text = Math.Round(calc.SideAB, Convert.ToInt32(numDigits.Value)).ToString();
			txtBC.Text = Math.Round(calc.SideBC, Convert.ToInt32(numDigits.Value)).ToString();
			txtAC.Text = Math.Round(calc.SideAC, Convert.ToInt32(numDigits.Value)).ToString();
			txtA.Text = Math.Round(calc.AngleA, Convert.ToInt32(numDigits.Value)).ToString();
			txtB.Text = Math.Round(calc.AngleB, Convert.ToInt32(numDigits.Value)).ToString();
			txtC.Text = Math.Round(calc.AngleC, Convert.ToInt32(numDigits.Value)).ToString();
			txtPerimeter.Text = Math.Round(calc.Perimeter, Convert.ToInt32(numDigits.Value)).ToString();
			txtArea.Text = Math.Round(calc.Area, Convert.ToInt32(numDigits.Value)).ToString();
			if ((chkMedian.Checked == false))
			{
				txtAltidudeAB.Text = Math.Round(calc.Height(Bases.AB), Convert.ToInt32(numDigits.Value)).ToString();
				txtAltidudeBC.Text = Math.Round(calc.Height(Bases.BC), Convert.ToInt32(numDigits.Value)).ToString();
				txtAltidudeAC.Text = Math.Round(calc.Height(Bases.AC), Convert.ToInt32(numDigits.Value)).ToString();
			}
			else
			{
				txtAltidudeAB.Text = Math.Round(calc.Median(Bases.AB), Convert.ToInt32(numDigits.Value)).ToString();
				txtAltidudeBC.Text = Math.Round(calc.Median(Bases.BC), Convert.ToInt32(numDigits.Value)).ToString();
				txtAltidudeAC.Text = Math.Round(calc.Median(Bases.AC), Convert.ToInt32(numDigits.Value)).ToString();
			}

			DrawingData = new TriangleData(calc);
			DrawingData.Altitudes = !chkMedian.Checked;
			this.bitmap = DrawingData.Draw((Panel1.Height - 2));
			this.Refresh();

		}
		string[] NItems= new string[]  {"AB_BC_AC", "AB_BC_A", "AB_BC_B", "AB_BC_C", "BC_AC_A", "BC_AC_B", "BC_AC_C", "AB_AC_A", "AB_AC_B", "AB_AC_C", "AB_A_B", "AB_B_C", "AB_C_A", "BC_A_B", "BC_B_C", "BC_C_A", "AC_A_B", "AC_B_C", "AC_C_A"};
		string[] GItems = new string[] { "c_a_b", "c_a_α", "c_a_β", "c_a_γ", "a_b_α", "a_b_β", "a_b_γ", "b_c_α", "b_c_β", "b_c_γ", "c_α_β", "c_β_γ", "c_γ_α", "a_α_β", "a_β_γ", "a_γ_α", "b_α_β", "b_β_γ", "b_γ_α" };

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(Pens.Black, 0, 0, (Panel1.Width - 1), (Panel1.Height - 1));
			if (bitmap != null)
			{
				e.Graphics.DrawImage(bitmap, 1, 1);
			}
		}

		private void chkGreek_CheckedChanged(object sender, EventArgs e)
		{
			cmbType.Items.Clear();
			if ((chkGreek.Checked == true))
			{
				lblSideAB.Text = "c";
				lblSideBC.Text = "a";
				lblSideAC.Text = "b";
				lblSideA.Text = "α";
				lblSideB.Text = "β";
				lblSideC.Text = "γ";
				lblA.Text = "A";
				lblP.Text = "p";
				cmbType.Items.AddRange(GItems);
			}
			else
			{
				lblSideAB.Text = "AB";
				lblSideBC.Text = "BC";
				lblSideAC.Text = "AC";
				lblSideA.Text = "A";
				lblSideB.Text = "B";
				lblSideC.Text = "C";
				lblA.Text = "Area";
				lblP.Text = "Perimeter";
				cmbType.Items.AddRange(NItems);
			}

			cmbType.SelectedIndex = 0;
		}

		private void Panel1_SizeChanged(object sender, EventArgs e)
		{
			if (DrawingData != null)
			{
				bitmap = DrawingData.Draw(Panel1.Height);
			}
			Panel1.Refresh();
		}

		private void chkAmbigious_CheckedChanged(object sender, EventArgs e)
		{
			btnCalculate.PerformClick();
		}

		private void chkMedian_CheckedChanged(object sender, EventArgs e)
		{
			btnCalculate.PerformClick();
			if (chkMedian.Checked)
			{
				GroupBox4.Text = "Medians";
			}
			else
			{
				GroupBox4.Text = "Altitudes";
			}

		}


		private void Panel1_DoubleClick(object sender, EventArgs e)
		{
			if (bitmap != null)
			{
				frmDisplay frm = new frmDisplay(this);
				frm.Show(this);

			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			frmAbout frm = new frmAbout();
			frm.ShowDialog(this);
		}

    }
}
