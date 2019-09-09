using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public static class MathLength
	{
		public static double GetLength(Point A, Point B)
		{
			return Math.Sqrt(Math.Pow((A.Y - B.Y), 2) + Math.Pow((A.X - B.X), 2));
		}
	}
}
