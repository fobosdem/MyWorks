using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineAndProducts
{
	public class Part : Product
	{
		public string Dimensions { get; set; }
		public Part(string dimensions, string type, string name, int qty, int price) : base(type, name, qty, price)
		{
			Dimensions = dimensions;
		}
		public override string GetAllInfo()
		{
			return $"{Type} {Name} (Dimensions: {Dimensions}): qty = {Qty}, Price = {Price}$";
		}
	}
}
