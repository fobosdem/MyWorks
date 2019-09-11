using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	

    public class Trapeciya : Figura
    {

		public override double Area
		{
			get
			{
				return 0.5 * (MathLength.GetLength(Points[1], Points[2]) + MathLength.GetLength(Points[0], Points[3])) * (Points[1].Y - Points[0].Y);
			}
		}

		public override bool CheckRavnobedr
		{
			get
			{
				return (MathLength.GetLength(Points[0], Points[2]) == MathLength.GetLength(Points[3], Points[1]));
			}
		}
		public Trapeciya(Point[] points): base(points)
		{
			if(points.Length>4)
			{
				throw new Exception("Can take array of 4 doubles");
			}
		}

		public override string TypeOfFigure()
		{
			string result;
			if (MathLength.GetLength(Points[0], Points[2]) == MathLength.GetLength(Points[1], Points[3]))
			{
				result = "Figure is square";
			}
			else
			{
				result = "Some sort of quadrangle";
			}
			return result;
		}

	}
}
