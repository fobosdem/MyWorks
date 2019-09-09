﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Chose task 1 - figures; 2 - circle;");
			switch (int.Parse(Console.ReadLine()))
			{
				case 1:
					List<Figura> figuri = new List<Figura>();

					Console.WriteLine("Vvedite chislo figur");
					int kolichestvo = int.Parse(Console.ReadLine());

					for (int i = 0; i < kolichestvo; i++)
					{
						Console.WriteLine("Viberite figuru:");
						Console.WriteLine("1 - triugolnik");
						Console.WriteLine("2 - trapeciya");
						int figura = int.Parse(Console.ReadLine());

						switch (figura)
						{
							case 1:
								Point[] pointsTriug = new Point[3];
								for (int tr = 0; tr < 3; tr++)
								{
									Console.WriteLine($"Koordinati {tr + 1} tochki:");
									Console.Write("X = ");
									pointsTriug[tr].X = int.Parse(Console.ReadLine());
									Console.Write("Y = ");
									pointsTriug[tr].Y = int.Parse(Console.ReadLine());
								}
								Triugulnik triugulnik = new Triugulnik(pointsTriug);
								figuri.Add(triugulnik);
								break;
							case 2:
								Point[] pointsTrapec = new Point[4];
								for (int trap = 0; trap < 4; trap++)
								{
									Console.WriteLine($"Koordinat {trap + 1} tochki:");
									Console.Write("X = ");
									pointsTrapec[trap].X = int.Parse(Console.ReadLine());
									Console.Write("Y = ");
									pointsTrapec[trap].Y = int.Parse(Console.ReadLine());
								}
								Trapeciya trapecia = new Trapeciya(pointsTrapec);
								figuri.Add(trapecia);
								break;
						}
					}

					double[] ploshyadi = new double[kolichestvo];

					int numberOfTrap = 0;
					foreach (var figura in figuri)
					{
						Console.WriteLine($"{numberOfTrap + 1} {nameof(figura)} ravnobedrennaya = {figura.CheckRavnobedr}, ploshyad = {figura.Area}, perimetr = {figura.Perimetr}");
						ploshyadi[numberOfTrap] = figura.Area;
						numberOfTrap++;
					}

					double srednPloshyad = ploshyadi.Sum() / ploshyadi.Length;

					int kolichestvoVisheSredn = 0;

					for (int i = 0; i < ploshyadi.Length; i++)
					{
						if (ploshyadi[i] > srednPloshyad)
						{
							kolichestvoVisheSredn++;
						}
					}
					Console.WriteLine($"Kolichestvo figur s bolshei ploshyadu po bolnitse = {kolichestvoVisheSredn}");
					Console.WriteLine();
					break;
				case 2:
					Circle[] circles = new Circle[2];
					for (int i = 0; i < 2; i++)
					{
						Console.WriteLine($"Points of {i + 1}st circle");
						Console.Write("X = ");
						double pointX = double.Parse(Console.ReadLine());
						Console.Write("Y = ");
						double pointY = double.Parse(Console.ReadLine());
						Point centerofCircle = new Point(pointX, pointY);
						Console.Write("radius = ");
						double radius = double.Parse(Console.ReadLine());

						circles[i] = new Circle(centerofCircle, radius);
					}

					Console.WriteLine(circles[0].Equals(circles[1]));
					break;
			}
			Console.ReadKey();
		}
	}
}
