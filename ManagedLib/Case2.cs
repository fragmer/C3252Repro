using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedLib.Case2
{
    public class Foo
    {
        private readonly ThingHandler<CoreFoo> _handler;
    }

    internal abstract class CoreFoo
    {
        ~CoreFoo() // internal class must have a destructor
        {
        }
    }

    internal sealed class ThingHandler<T>
        where T : CoreFoo
    {
    }
}
