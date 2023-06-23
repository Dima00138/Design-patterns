using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class C3 : C2, I1
    {
        public C3() : base() { }

        public C3(C3 c) : base(c) { }

        public C3(int prifi, int pubfi, int profi, int pripro, int pubpro, int propro)
            : base(prifi, pubfi, profi, pripro, pubpro, propro) { }
    }
}
