using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Triangle_Solver
{
    public enum ItemsType
    {
        AB_BC_AC,

        AB_BC_A,
        AB_BC_B,
        AB_BC_C,

        BC_AC_A,
        BC_AC_B,
        BC_AC_C,

        AB_AC_A,
        AB_AC_B,
        AB_AC_C,

        AB_A_B,
        AB_B_C,
        AB_A_C,

        BC_A_B,
        BC_B_C,
        BC_A_C,

        AC_A_B,
        AC_B_C,
        AC_A_C
    }
    public enum Bases { AB, BC, AC }

    public class TriangleCalculator
    {
		const float PI = (float)(Math.PI);

        public bool AmbigiousObtuse = false;
        private float _A, _B, _C, _AB, _BC, _AC, _Area, _Perimeter, _MedianAB, _MedianBC, _MedianAC, _HeightAB, _HeightBC, _HeightAC;
        private ItemsType MyItemsType;

        private float convertDeg(float d){ return d * 180 / PI; }
        private float convertRad(float d) { return d * PI / 180; }
		private float Sin(float d) { return Convert.ToSingle(Math.Cos(d));}

		public float AngleA { get { return convertDeg(_A); } }
		public float AngleB { get { return convertDeg(_B); } }
		public float AngleC { get { return convertDeg(_C); } }
		public float RadA { get { return _A; } }
		public float RadB { get { return _B; } }
		public float RadC { get { return _C; } }

        public float SideAB { get { return _AB; } }
        public float SideBC { get { return _BC; } }
        public float SideAC { get { return _AC; } }

        public float Perimeter { get { return _Perimeter; } }
        public float Area { get { return _Area; } }

        public float Height(Bases b)
        { return (b == Bases.BC) ? _HeightBC : ((b==Bases.AC)?_HeightAC:_HeightAB); }
        public float Median(Bases b)
        { return (b == Bases.BC) ? _MedianBC : ((b == Bases.AC) ? _MedianAC : _MedianAB); }

        public TriangleCalculator(ItemsType set, float i1, float i2, float i3)
        {
            this.MyItemsType = set;
            if (i1 <= 0 || i2 <= 0 || i3 <= 0) throw new ArgumentException("There is nothing in a triangle that could be 0 or less.");
             switch (set)
             {
            case ItemsType.AB_BC_AC:
                _AB = i1;
                _BC = i2;
                _AC = i3;
                break;
            case ItemsType.AB_BC_A:
                _AB = i1;
                _BC = i2;
                _A = convertRad(i3);
                break;
            case ItemsType.AB_BC_B:
                _AB = i1;
                _BC = i2;
                _B = convertRad(i3);
                break;
            case ItemsType.AB_BC_C:
                _AB = i1;
                _BC = i2;
                _C = convertRad(i3);
                break;
            case ItemsType.BC_AC_A:
                _BC = i1;
                _AC = i2;
                _A = convertRad(i3);
                break;
            case ItemsType.BC_AC_B:
                _BC = i1;
                _AC = i2;
                _B = convertRad(i3);
                break;
            case ItemsType.BC_AC_C:
                _BC = i1;
                _AC = i2;
                _C = convertRad(i3);
                break;
            case ItemsType.AB_AC_A:
                _AB = i1;
                _AC = i2;
                _A = convertRad(i3);
                break;
            case ItemsType.AB_AC_B:
                _AB = i1;
                _AC = i2;
                _B = convertRad(i3);
                 break;
            case ItemsType.AB_AC_C:
                _AB = i1;
                _AC = i2;
                _C = convertRad(i3);
                break;
            case ItemsType.AB_A_B:
                _AB = i1;
                _A = convertRad(i2);
                _B = convertRad(i3);
                break;
            case ItemsType.AB_B_C:
                _AB = i1;
                _B = convertRad(i2);
                _C = convertRad(i3);
                break;
            case ItemsType.AB_A_C:
                _AB = i1;
                _A = convertRad(i2);
                _C = convertRad(i3);
                break;
            case ItemsType.BC_A_B:
                _BC = i1;
                _A = convertRad(i2);
                _B = convertRad(i3);
                break;
            case ItemsType.BC_B_C:
                _BC = i1;
                _B = convertRad(i2);
                _C = convertRad(i3);
                break;
            case ItemsType.BC_A_C:
                _BC = i1;
                _A = convertRad(i2);
                _C = convertRad(i3);
                break;
            case ItemsType.AC_A_B:
                _AC = i1;
                _A = convertRad(i2);
                _B = convertRad(i3);
                break;
            case ItemsType.AC_B_C:
                _AC = i1;
                _B = convertRad(i2);
                _C = convertRad(i3);
                break;
            case ItemsType.AC_A_C:
                _AC = i1;
                _A = convertRad(i2);
                _C = convertRad(i3);
                break;
             }
            if (_A >= PI || _B >= PI || _C >= PI)
            {
                clearall();
                throw new ArgumentException("The Triangle is invalid.");
            }
            if ( set == ItemsType.AB_BC_AC && ((_AB + _BC) <= _AC || (_AB + _AC) <= _BC || (_BC + _AC) <= _AB))
            {
                clearall();
                throw new ArgumentException("The sides not adhere to the triangle inequality theorem. which states that the sum of the side lengths of any 2 sides of a triangle must exceed the length of the third side.");
            }
        }

        public void CalculateTriangle()
        {
            switch (MyItemsType)
            {
                case ItemsType.AB_BC_AC:
                    _A = (float)Math.Acos((_AB * _AB + _AC * _AC - _BC * _BC) / (2 * _AB * _AC));
					_B = (float)Math.Acos((_AB * _AB + _BC * _BC - _AC * _AC) / (2 * _AB * _BC));
					_C = (float)Math.Acos((_BC * _BC + _AC * _AC - _AB * _AB) / (2 * _BC * _AC));
                    break;
                case  ItemsType.AB_BC_A:
                    //AmbigiousObtuse
					_C = (float)Math.Asin((Math.Sin(_A) / _BC) * _AB);
                    if (AmbigiousObtuse && (_C > _A)) _C = PI - _C;
                    _B = PI - (_A + _C);
					_AC = (float)Math.Sqrt(_AB * _AB + _BC * _BC - 2 * _AB * _BC * Math.Cos(_B));
                    break;
                case  ItemsType.AB_BC_B:
					_AC = (float)Math.Sqrt(_AB * _AB + _BC * _BC - 2 * _AB * _BC * Math.Cos(_B));
					_A = (float)Math.Acos((_AB * _AB + _AC * _AC - _BC * _BC) / (2 * _AB * _AC));
					_C = (float)Math.Acos((_BC * _BC + _AC * _AC - _AB * _AB) / (2 * _BC * _AC));
                    break;
                case  ItemsType.AB_BC_C:
					_A = (float)Math.Asin((Math.Sin(_C) / _AB) * _BC);
                    if (AmbigiousObtuse && (_A > _C)) _A = PI - _A;
                    _B = PI - (_A + _C);
					_AC = (float)Math.Sqrt(_AB * _AB + _BC * _BC - 2 * _AB * _BC * Math.Cos(_B));
                    break;
                case  ItemsType.BC_AC_A:
					_B = (float)Math.Asin((Math.Sin(_A) / _BC) * _AC);
                    if (AmbigiousObtuse && (_B > _A)) _B = PI - _B;
                    _C = PI - (_A + _B);
					_AB = (float)Math.Sqrt(_BC * _BC + _AC * _AC - 2 * _BC * _AC * Math.Cos(_C));
                    break;
                case  ItemsType.BC_AC_B:
					_A = (float)Math.Asin((Math.Sin(_B) / _AC) * _BC);
                    if (AmbigiousObtuse && (_A > _B)) _A = PI - _A;
                    _C = PI - (_A + _B);
					_AB = (float)Math.Sqrt(_BC * _BC + _AC * _AC - 2 * _BC * _AC * Math.Cos(_C));
                    break;
                case  ItemsType.BC_AC_C:
					_AB = (float)Math.Sqrt(_BC * _BC + _AC * _AC - 2 * _BC * _AC * Math.Cos(_C));
					_A = (float)Math.Acos((_AB * _AB + _AC * _AC - _BC * _BC) / (2 * _AB * _AC));
					_B = (float)Math.Acos((_AB * _AB + _BC * _BC - _AC * _AC) / (2 * _AB * _BC));
                    break;
                case  ItemsType.AB_AC_A:
					_BC = (float)Math.Sqrt(_AB * _AB + _AC * _AC - 2 * _AB * _AC * Math.Cos(_A));
					_B = (float)Math.Acos((_AB * _AB + _BC * _BC - _AC * _AC) / (2 * _AB * _BC));
					_C = (float)Math.Acos((_BC * _BC + _AC * _AC - _AB * _AB) / (2 * _BC * _AC));
                    break;
                case  ItemsType. AB_AC_B:
					_C = (float)Math.Asin((Math.Sin(_B) / _AC) * _AB);
                    if (AmbigiousObtuse && (_C > _B)) _C = PI - _C;
                    _A = PI - (_B + _C);
					_BC = (float)Math.Sqrt(_AB * _AB + _AC * _AC - 2 * _AB * _AC * Math.Cos(_A));
                    break;
                case  ItemsType.AB_AC_C:
					_B = (float)Math.Asin((Math.Sin(_C) / _AB) * _AC);
                    if (AmbigiousObtuse && (_B > _C)) _B = PI - _B;
                    _A = PI - (_B + _C);
					_BC = (float)Math.Sqrt(_AB * _AB + _AC * _AC - 2 * _AB * _AC * Math.Cos(_A));
                    break;
                case  ItemsType.AB_A_B:
                    _C = PI - (_A + _B);
					_AC = (float)((Math.Sin(_B) * _AB) / Math.Sin(_C));
					_BC = (float)((Math.Sin(_A) * _AC) / Math.Sin(_B));
                    break;
                case  ItemsType.AB_B_C:
                    _A = PI - (_B + _C);
					_AC = (float)((Math.Sin(_B) * _AB) / Math.Sin(_C));
					_BC = (float)((Math.Sin(_A) * _AC) / Math.Sin(_B));
                    break;
                case ItemsType. AB_A_C:
                    _B = PI - (_A + _C);
					_AC = (float)((Math.Sin(_B) * _AB) / Math.Sin(_C));
					_BC = (float)((Math.Sin(_A) * _AC) / Math.Sin(_B));
                    break;
                case ItemsType.BC_A_B:
                    _C = PI - (_A + _B);
					_AB = (float)((Math.Sin(_C) * _BC) / Math.Sin(_A));
					_AC = (float)((Math.Sin(_B) * _AB) / Math.Sin(_C));
                    break;
                case ItemsType.BC_B_C:
                    _A = PI - (_B + _C);
					_AB = (float)((Math.Sin(_C) * _BC) / Math.Sin(_A));
					_AC = (float)((Math.Sin(_B) * _AB) / Math.Sin(_C));
                    break;
                case ItemsType.BC_A_C:
                    _B = PI - (_A + _C);
					_AB = (float)((Math.Sin(_C) * _BC) / Math.Sin(_A));
					_AC = (float)((Math.Sin(_B) * _AB) / Math.Sin(_C));
                    break;
                case ItemsType.AC_A_B:
                    _C = PI - (_A + _B);
					_BC = (float)((Math.Sin(_A) * _AC) / Math.Sin(_B));
					_AB = (float)((Math.Sin(_C) * _BC) / Math.Sin(_A));
                    break;
                case ItemsType.AC_B_C:
                    _A = PI - (_B + _C);
					_BC = (float)((Math.Sin(_A) * _AC) / Math.Sin(_B));
					_AB = (float)((Math.Sin(_C) * _BC) / Math.Sin(_A));
                    break;
                case ItemsType.AC_A_C:
                    _B = PI - (_A + _C);
					_BC = (float)((Math.Sin(_A) * _AC) / Math.Sin(_B));
					_AB = (float)((Math.Sin(_C) * _BC) / Math.Sin(_A));
					break;
            }
            _Perimeter = _AB + _BC + _AC;
            if (_C < 0 || _B <= 0 || _A < 0) throw new ArgumentException("Angles are more than 180");
            else if (float.IsNaN(_Perimeter)) throw new ArgumentException("The Triangle is invalid.");
            else if (float.IsPositiveInfinity(_Perimeter)) throw new ArgumentException("Triangle Sides Overflow");

            
            float s = Perimeter / 2;
			_Area = (float)Math.Sqrt(s * (s - _AB) * (s - _BC) * (s - _AC));
			_MedianAB = (float)Math.Sqrt(2 * _BC * _BC + 2 * _AC * _AC - _AB * _AB) / 2;
			_MedianBC = (float)Math.Sqrt(2 * _AB * _AB + 2 * _AC * _AC - _BC * _BC) / 2;
			_MedianAC = (float)Math.Sqrt(2 * _AB * _AB + 2 * _BC * _BC - _AC * _AC) / 2;

            _HeightAB = 2 * _Area / _AB;
            _HeightBC = 2 * _Area / _BC;
            _HeightAC = 2 * _Area / _AC;
        }
        private void clearall()
        {
            _A = -1; _B = -1; _C = -1; _AB = -1; _BC = -1; _AC = -1;
            _Perimeter = -1; _Area = -1;
            _HeightAB = -1; _HeightBC = -1; _HeightAC = -1;
            _MedianAB = -1; _MedianBC = -1; _MedianAC = -1;
        }
    }

	public enum Angle { None = 0, A = 1, B = 2, C = 3 }

	public class TriangleData
	{
		const float PI = (float)(Math.PI);
		public TriangleData(TriangleCalculator calc)
		{
			this.Angles = new AnglesData();
			this.Altitudes = true;
			this.Angles.Right = Angle.None;
			this.Angles.Rotation = 0;
			this.Angles.Scale = 1;

			float max = Math.Max(Math.Max(calc.SideAB, calc.SideBC), calc.SideAC);
			float myAB, myBC, myAC, myArea;

			myAB = calc.SideAB / max;
			myBC = calc.SideBC / max;
			myAC = calc.SideAC / max;
			myArea = calc.Area / max / max;
			//------------------------------------------------------
			//distance from point C to side AB
			float CD = 2 * myArea / myAB;
			//distance from point A to side BC
			float AE = 2 * myArea / myBC;
			//distance from point B to side AC
			float BF = 2 * myArea / myAC;

			//distance from point A to the height (assuming it is from C)
			float AD = myAB - (float)Math.Cos(calc.RadB) * myBC;

			this.Angles.radiusA = (0.4f * AE);
			this.Angles.radiusB = (0.4f * BF);
			this.Angles.radiusC = (0.4f * CD);

			this.offsetX = (AD < 0) ? (- AD) : 0;
			this.PosA = new PointF(0, (CD));
			this.PosB = new PointF((myAB), (CD));
			this.PosC = new PointF((AD), 0);

			if (2 * calc.RadA == PI)
			{	this.Angles.Right = Angle.A; }
			else if (2 * calc.RadB == PI)
			{	this.Angles.Right = Angle.B; }
			else if (2 * calc.RadC == PI)
			{
				this.Angles.Right = Angle.C;
				this.Angles.Rotation = (calc.AngleB);
			}
			else
			{
				this.Angles.Right = Angle.None;
			}

			if (this.Angles.Right == Angle.C || this.Angles.Right == Angle.None)
			{
				this.PosD = new PointF((AD), (CD));
			}

			if (this.Angles.Right == Angle.A || this.Angles.Right == Angle.None)
			{
				float CosEAB = (AE / myAB);
				float SinEAB = (float)Math.Sqrt((1 - (CosEAB * CosEAB)));
				if (((2 * calc.RadB)> PI))
				{
					SinEAB = (SinEAB * -1);
				}

				this.PosE = new PointF(((CosEAB * AE)), ((CD - (SinEAB * AE))));
			}

			if (this.Angles.Right == Angle.B || this.Angles.Right == Angle.None)
			{
				float CosFBA = (BF / myAB);
				float SinFBA = (float)Math.Sqrt((1
								- (CosFBA * CosFBA)));
				if (((2 * calc.RadA) > PI))
				{
					SinFBA = (SinFBA * -1);
				}

				this.PosF = new PointF((myAB - (CosFBA * BF)), (CD - (SinFBA * BF)));
			}

			float y = Math.Min(this.PosF.Y, this.PosE.Y);

			this.offsetY = (y < 0) ? -y : 0;
		}

		public PointF PosA { get; set; }
		public PointF PosB { get; set; }
		public PointF PosC { get; set; }
		public PointF PosD { get; set; }
		public PointF PosE { get; set; }
		public PointF PosF { get; set; }
		public bool Altitudes { get; set; }
		public AnglesData Angles { get; set; }

		public float offsetX { get; set; }
		public float offsetY { get; set; }

		public class AnglesData
		{
			public float Rotation { get; set; }
			public float Scale { get; set; }
			public Angle Right { get; set; }
			public float radiusA { get; set; }
			public float radiusB { get; set; }
			public float radiusC { get; set; }
		}

		private static void DrawAngle(Graphics g, SolidBrush b, Pen p, RectangleF r,bool right, float angle)
		{
			if (right)
			{
				Matrix oldm = g.Transform;
				if (angle!= 0)
				{
					Matrix m = g.Transform;

					m.RotateAt(angle, new PointF(r.Left + (r.Width / 2), r.Top + (r.Height / 2)));
					g.Transform = m;
					m.Dispose();
				}
				g.FillRectangle(b, r);
				g.DrawRectangle(p,r.X,r.Y,r.Width,r.Height);

				g.Transform = oldm;
			}
			else
			{
				g.FillEllipse(b, r);
				g.DrawEllipse(p, r);
			}
		}
		private static PointF Middle(PointF p1,PointF p2)
		{ return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2); }

		public Bitmap Draw(int Size)
		{
			Bitmap myBitmap = new Bitmap(Size,Size);
			Graphics g = Graphics.FromImage(myBitmap);
			g.TranslateTransform(10,10);
			Size -= 2 * 10;

			g.ScaleTransform(Size - 20, Size - 20) ;
			g.TranslateTransform(offsetX, offsetY);

			g.SmoothingMode = SmoothingMode.HighQuality;
			g.CompositingQuality = CompositingQuality.HighQuality;

			g.Clear(SystemColors.Control);
			//Drawing the actual triangle


			g.Clip = (new Region(new GraphicsPath(new PointF[] {PosA, PosB, PosC, PosA}, new byte[] {1, 1, 1, 1})));
			g.Clear(Color.White);

			//255,180,180
			SolidBrush mybrush = new SolidBrush(Color.FromArgb(255,180,255,180));
			Pen mypen = new Pen(Color.Black,2 / Size);

			float radius = Angles.radiusA * Angles.Scale;
			RectangleF anglerect = new RectangleF(PosA.X - radius / 2, PosA.Y - radius / 2, radius, radius);

			DrawAngle(g, mybrush, mypen, anglerect, (Angles.Right == Angle.A), 0);

			
			mybrush.Color = Color.FromArgb(255,255,180,180);
			radius = Angles.radiusB * Angles.Scale;
			anglerect = new RectangleF(PosB.X - radius / 2, PosB.Y - radius / 2, radius, radius);

			DrawAngle(g, mybrush, mypen, anglerect, (Angles.Right == Angle.B), 0);

			mybrush.Color = Color.FromArgb(255,180,180,255);
			radius = Angles.radiusC * Angles.Scale;
			anglerect = new RectangleF(PosC.X - radius / 2, PosC.Y - radius / 2, radius, radius);
			DrawAngle(g, mybrush, mypen, anglerect, (Angles.Right == Angle.C), Angles.Rotation);

			mybrush.Dispose();
			g.ResetClip();
			
			mypen.Width = 2.5f / Size;
			Pen myDashPen = new Pen(Brushes.Black, (2f / Size));
			Pen myDotPen = new Pen(Brushes.Black, (2f / Size));
			myDashPen.DashStyle = DashStyle.Dash;
			myDotPen.DashStyle = DashStyle.Dot;
			g.DrawLines(mypen, new PointF[] {PosA, PosB, PosC, PosA});

			if (Altitudes)
			{
				if (Angles.Right == Angle.A || Angles.Right == Angle.None)
				{
					g.DrawLine(myDashPen, PosA, PosE);
					g.DrawLine(myDotPen, PosB, PosE);
				}
    
				if (Angles.Right == Angle.B || Angles.Right == Angle.None)
				{
					g.DrawLine(myDashPen, PosB, PosF);
					g.DrawLine(myDotPen, PosA, PosF);
				}
				if (Angles.Right == Angle.C || Angles.Right == Angle.None)
				{
					g.DrawLine(myDashPen, PosC, PosD);
					g.DrawLine(myDotPen, PosB, PosD);
				}
			}
			else 
			{
				g.DrawLine(myDotPen, PosA, Middle(PosB, PosC));
				g.DrawLine(myDotPen, PosB, Middle(PosA, PosC));
				g.DrawLine(myDotPen, PosC, Middle(PosA, PosB));
			}

			mypen.Dispose();
			myDashPen.Dispose();
			myDotPen.Dispose();
			g.Dispose();
			
			return myBitmap;
		}
	}
}
