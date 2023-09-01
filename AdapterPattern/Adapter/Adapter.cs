using AdapterPattern.Target;
using AdapterPattern.Adaptee;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class Adapter : ITarget
    {
		// The Adapter makes the Adaptee's interface compatible with the Target's
		// interface.

		private readonly Adaptee.Adaptee _adaptee;

        public Adapter(Adaptee.Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }
}
