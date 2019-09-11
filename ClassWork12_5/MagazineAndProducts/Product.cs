using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineAndProducts
{
	public abstract class Product
	{
		public string Type { get; set; }
		public string Name { get; set; }
		public int Qty { get; set; }
		public int Price { get; set; }

		public Product(string type, string name, int qty, int price)
		{
			Type = type;
			Name = name;
			Qty = qty;
			Price = price;
		}
		public virtual string GetAllInfo()
		{
			return $"{Type} {Name}: qty = {Qty}, Price = {Price}$";
		}
	}
}
