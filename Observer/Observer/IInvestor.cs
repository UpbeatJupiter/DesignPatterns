using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
	/// <summary>
	/// The 'Observer' interface
	/// </summary>
	public interface IInvestor
	{
		void Update(Stock stock);
	}

}
