using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	//This is the Model class that is going to hold the Product information i.e. Led TV Details
	public class LEDTV
	{
		//Properties of the LED TV
		public string Size { get; set; }
		public string Price { get; set; }
		public bool USBSupport { get; set; }

		//Initializing the Properties using Constructor
		public LEDTV(string Size, string Price, bool USBSupport)
		{
			this.Size = Size;
			this.Price = Price;
			this.USBSupport = USBSupport;
		}

		//Fetching the Details of the LedTV
		public string GetDetails()
		{
			return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + "]";
		}
	}
}
