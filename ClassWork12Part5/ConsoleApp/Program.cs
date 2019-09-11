using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowersClassLibrary;

namespace ConsoleApp
{
	class Program
	{
		static void Main()
		{
			Gvozdikes gvozdiki = new Gvozdikes("Gvozdiki", 100);
			Roses roses = new Roses("Rose", 120);
			Tulpanes tulpanes = new Tulpanes("Tulpan", 80);

			Flower[] flowers = new Flower[3]{ gvozdiki, roses, tulpanes };

			Random rnd = new Random();

			Buket buket = new Buket();

			Console.WriteLine("Vvedite kolichestvo cvetkov v bukete");
			int numberOfFlowers = 0;
			do
			{
				Console.Write("Kolichestvo = ");
			} while (!int.TryParse(Console.ReadLine(), out numberOfFlowers) || numberOfFlowers == 0);
			int FlowersLeft = 0;
			do
			{
				buket.AddFlowerToBuket(flowers[rnd.Next(0, 2)]);
				FlowersLeft++;
			} while (FlowersLeft < numberOfFlowers);

			Console.WriteLine(buket.ReturnBuket());

			Console.ReadKey();
		}
	}
}
