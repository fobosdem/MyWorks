using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public abstract class Figura
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
	}
}
