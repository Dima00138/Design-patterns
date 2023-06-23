using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class C4 : C3
    {
        public C4() : base() { }

        public new void Hello()
        {
            Console.WriteLine("GoodBye");
        }

        public C4(C4 c) : base(c) { }

        public C4(int prifi, int pubfi, int profi, int pripro, int pubpro, int propro)
            : base(prifi, pubfi, profi, pripro, pubpro, propro) { }
    }
}
