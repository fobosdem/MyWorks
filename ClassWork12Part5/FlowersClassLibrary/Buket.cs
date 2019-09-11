using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersClassLibrary
{
	public class Buket
	{
		public int Price = 0;
		public Dictionary<string, int> Flowers { get; set; }

		public Buket()
		{
			Flowers = new Dictionary<string, int>();
		}


		public void AddFlowerToBuket(Flower flower)
		{
			if (Flowers.ContainsKey(flower.Name))
			{
				this.Flowers[flower.Name]++;
				Price += flower.Price;
			}
			else
			{
				this.Flowers.Add(flower.Name, 1);
				Price += flower.Price;
			}
		}
		public string ReturnBuket()
		{
			string result = "Buket coderjit ";
			foreach (var buketFlower in Flowers)
			{
				result += $"{buketFlower.Key} {buketFlower.Value}, ";
			}
			result += $" stoimost' {Price}";
			return result;

		}
	}
}
