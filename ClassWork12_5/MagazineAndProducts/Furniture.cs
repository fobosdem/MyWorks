using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineAndProducts
{
	public class Furniture : Product
	{
		public string MAnufacturer { get; set; }
		public Furniture(string manufacturer, string type, string name, int qty, int price) : base(type, name, qty, price)
		{
			MAnufacturer = manufacturer;
		}
		public override string GetAllInfo()
		{
			return $"{Type} {Name} (manuf: {MAnufacturer}): qty = {Qty}, Price = {Price}$";
		}
	}
}
