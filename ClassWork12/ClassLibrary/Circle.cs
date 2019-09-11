using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Circle : Figura
	{
		public Circle(Point centr, double radius1, double radius2)
		{
			Point[] points = new Point[3];
			points[0] = centr;
			points[1] = new Point(centr.X, centr.Y + radius1);
			points[2] = new Point(centr.X, centr.Y + radius2);
			base.Points = points;
		}

		public override double Area
		{
			get
			{
				return Math.PI * Math.Pow(MathLength.GetLength(Points[0], Points[1]), 2);
			}
		}

		public override string TypeOfFigure()
		{
			string result;
			if (Points[1].Y == Points[2].Y)
			{
				result = "Figure is circle";
			}
			else
			{
				result = "Figure is elips";
			}
			return result;
		}

		public override string ToString()
		{
			return $"{TypeOfFigure()}, ploshyad = {Area}, perimetr = {Perimetr}";
		}

		public static bool operator ==(Circle c1, Circle c2)
		{
			return c1.Equals(c2);

		}
		public static bool operator !=(Circle c1, Circle c2)
		{
			if (c1.Equals(c2))
			{
				return false;
			}
			return true;
		}

		public override bool Equals(object obj)
		{
			var item = obj as Circle;
			
			return this.Area.Equals(item.Area);
		}
		//public override bool Equals(object circle)
		//{
		//	return 
		//}
	}
}
