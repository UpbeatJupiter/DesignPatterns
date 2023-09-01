using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
	public class House
	{
		private string basement;
		private string structure;
		private string roof;
		private string interior;

		public void setBasement(string basement)
		{
			this.basement = basement;
		}

		public void setStructure(string structure)
		{
			this.structure = structure;
		}

		public void setRoof(string roof)
		{
			this.roof = roof;
		}

		public void setInterior(string interior)
		{
			this.interior = interior;
		}

		public override string ToString()
		{
			return $"Basement: {basement}, Structure: {structure}, Roof: {roof}, Interior: {interior}";
		}
	}
}
