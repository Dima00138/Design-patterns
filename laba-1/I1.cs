using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal interface I1
    {
        int[] arrs { get; set; }

        public void No();
        delegate void de();
        event de deEv;
        int this[int i] {
            get
            {
                return arrs[i];
            }
            set
            {
                arrs[i] = value;
            }
        }
    }
}
