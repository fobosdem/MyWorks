using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public struct Point
	{
		public double X { get; set; }
		public double Y { get; set; }
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
	}
	public abstract class Figura : IDrawingInterface
	{
		public Point[] Points { get; set; }
		protected Figura()
		{

		}

		public Figura(Point[] points)
		{
			Points = points;
		}

		public virtual bool CheckRavnobedr
		{
			get
			{
				return false;
			}
		}

		public virtual double Area
		{
			get
			{
				return 0.0;
			}
		}

		public double Perimetr
		{
			get
			{
				double result = 0;
				for (int i = 0; i < Points.Length; i++)
				{
					if (i < Points.Length - 1)
					{
						result += MathLength.GetLength(Points[i], Points[i + 1]);
					}
					else
					{
						result += MathLength.GetLength(Points[i], Points[0]);
					}
				}
				return result;
			}
		}
		public void Drawing()
		{
		}
		public virtual string TypeOfFigure()
		{
			string result;
			switch (Points.Length)
			{
				case 3:
					if(Points[1].Y == Points[2].Y)
					{
						result =  "Figure is circle";
					}
					else
					{
						result = "Figure is elips";
					}
					break;

				case 4:
					if(MathLength.GetLength(Points[0], Points[2]) == MathLength.GetLength(Points[1], Points[3]))
					{
						result = "Figure is square";
					}
					else
					{
						result = "Some sort of quadrangle";
					}
					break;
				default:
					result = "Type of figure cant be reached";
					break;
			}
			return result;
		}
		public override string ToString()
		{
			return $"{TypeOfFigure()}, ploshyad = {Area}, perimetr = {Perimetr}";

		}
	}
}
