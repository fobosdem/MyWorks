using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Triugulnik : Figura
	{
		public override double Area
		{
			get
			{
				return 0.5 * MathLength.GetLength(Points[0], Points[2]) * (Points[1].Y - Points[0].Y);
			}
		}

		public override bool CheckRavnobedr
		{
			get
			{
				return (MathLength.GetLength(Points[0], Points[1]) == MathLength.GetLength(Points[1], Points[2]));
			}
		}

		public Triugulnik(Point[] points) : base(points)
		{
			if (points.Length > 3)
			{
				throw new Exception("Can take array of 3 doubles");
			}
		}
		public override string TypeOfFigure()
		{
			string result = "";
			if (Points.Length > 2)
			{
				result = "Figure is trirangle";
			}
			return result;
		}
	}
}
