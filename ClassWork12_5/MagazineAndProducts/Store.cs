using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineAndProducts
{
	public class Store
	{
		public string Name { get; set; }
		public int StoreSize { get; set; }
		private Product[] Products { get; set; }

		public Store(string name, int size)
		{
			Name = name;
			StoreSize = size;
			Products = new Product[size];
		}
		public void AddNewProduct(Product product)
		{
			int nullCount = 0;
			for (int i = 0; i < Products.Length; i++)
			{
				if (Products[i] == null)
				{
					Products[i] = product;
					break;
				}
				else
				{
					nullCount++;
				}
			}
			if (nullCount == Products.Length)
			{
				Console.WriteLine("You should chose another store, this one is full");
			}
		}

		public void GetAllInfoAboutStore()
		{
			Console.WriteLine($"Store {Name}");
			Console.WriteLine($"Store size: {StoreSize}");
			Console.WriteLine($"\t{Products.Length} products:");
			foreach (var product in Products)
			{
				Console.WriteLine($"\t\t{product.GetAllInfo()}");
			}

		}
	}
}
