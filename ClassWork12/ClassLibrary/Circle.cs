using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Circle : Figura
	{
		public Circle(Point centr, double radius)
		{
			Point[] points = new Point[2];
			points[0] = centr;
			points[1] = new Point(centr.X, centr.Y + radius);
			base.Points = points;
		}

		public override double Area
		{
			get
			{
				return Math.PI * Math.Pow(MathLength.GetLength(Points[0], Points[1]), 2);
			}
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
