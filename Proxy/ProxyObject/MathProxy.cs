using Proxy.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProxyObject
{
	public class MathProxy : IMath
	{
		private RealSubject.Math math = new RealSubject.Math();
		public double Add(double x, double y)
		{
			return math.Add(x, y);
		}
		public double Sub(double x, double y)
		{
			return math.Sub(x, y);
		}
		public double Mul(double x, double y)
		{
			return math.Mul(x, y);
		}
		public double Div(double x, double y)
		{
			return math.Div(x, y);
		}
	}
}
