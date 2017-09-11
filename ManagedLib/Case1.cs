using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedLib.Case1
{
    // a public class must explicitly implement the interface
    public class Foo : ICoreInterface<CoreFoo>
    {
        void ICoreInterface<CoreFoo>.DoSomething()
        {
        }
    }

    internal interface ICoreInterface<T>
        where T : CoreFoo // must have a constraint referencing internal class
    {
        void DoSomething();
    }

    internal abstract class CoreFoo
    {
        // type used as type constraint must have a destructor
        ~CoreFoo()
        {
        }
    }
}
