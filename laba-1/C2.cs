using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class C2 : C1, I1
    {
        public int[] arrs{ get; set; }
        public event I1.de deEv;

        public C2() : base() { }

        public C2(C2 c) : base(c) { }

        public C2(int prifi, int pubfi, int profi, int pripro, int pubpro, int propro) 
            : base(prifi, pubfi, profi, pripro, pubpro, propro) { }

        public void No()
        {
            Console.WriteLine("NO, GOD Please");
            deEv.Invoke();
        }

    }
}
