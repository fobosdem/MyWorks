using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazineAndProducts;

namespace ConsoleApp
{
	class Program
	{
		public static List<Store> stores = new List<Store>();
		static void Main()
		{
			do
			{
				Console.WriteLine("1 - add new store, 2 - add new product to some store, 3 - show information about some store");
				int menu = 0;
				do
				{
					Console.Write("Menu=");
				} while (!int.TryParse(Console.ReadLine(), out menu) || menu == 0);
				switch (menu)
				{
					case 1:
						Console.Write("Enter name of new store: ");
						string storeName = Console.ReadLine();
						Console.WriteLine("Enter size of the store");
						int size = 0;
						do
						{
							Console.Write("Size: ");
						} while (!int.TryParse(Console.ReadLine(), out size) || size == 0);
						stores.Add(new Store(storeName, size));
						break;

					case 2:
						if (stores.Any())
						{
							Console.WriteLine("Chose one of the store");
							int storeNumber = 0;
							foreach(var store in stores)
							{
								Console.WriteLine($"{storeNumber} {store.Name}");
								storeNumber++;
							}
							do
							{
								Console.Write("Store #: ");
							} while (!int.TryParse(Console.ReadLine(), out storeNumber) || storeNumber == 100000);

							Console.Write("Chose product: 1 - furniture, 2 - parts");
							int productTypeNumber = 0;
							do
							{
								Console.Write("Product: ");
							} while (!int.TryParse(Console.ReadLine(), out productTypeNumber) || productTypeNumber == 0);
							switch(productTypeNumber)
							{
								case 1:
									Console.Write("Furniture Type: ");
									string furnType = Console.ReadLine();
									Console.Write("Furniture name: ");
									string furnName = Console.ReadLine();
									Console.Write("MAnufacturer: ");
									string furnManuf = Console.ReadLine();
									Console.Write("Price: ");
									int furnPrice = int.Parse(Console.ReadLine());
									stores[storeNumber].AddNewProduct(new Furniture(furnManuf, furnType, furnName, 1, furnPrice));
									break;
								case 2:
									Console.Write("Part Type: ");
									string partType = Console.ReadLine();
									Console.Write("Part name: ");
									string partName = Console.ReadLine();
									Console.Write("Dimensions: ");
									string partDimensions = Console.ReadLine();
									Console.Write("Price: ");
									int partPrice = int.Parse(Console.ReadLine());
									stores[storeNumber].AddNewProduct(new Furniture(partDimensions, partType, partName, 1, partPrice));
									break;
							}

						}
						else Console.WriteLine("There is no any store in base");
						break;
					case 3:
						foreach(Store store in stores)
						{
							store.GetAllInfoAboutStore();
						}
						break;
				}
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
