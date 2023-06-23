using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class C1
    {
        private const int priconst = 0;
        public const int pubconst = 1;
        protected const int proconst = 2;
        private int prifi = 3;
        public int pubfi = 4;
        protected int profi = 5;
        private int pripro { get; set; }
        public int pubpro { get; set; }
        protected int propro { get; set; }

        public C1(int prifi, int pubfi, int profi, int pripro, int pubpro, int propro)
        {
            this.prifi = prifi;
            this.pubfi = pubfi;
            this.profi = profi;
            this.pripro = pripro;
            this.pubpro = pubpro;
            this.propro = propro;
        }

        public C1()
        {

        }

        public C1(C1 c)
        {
            this.prifi = c.prifi;
            this.pubfi = c.pubfi;
            this.profi = c.profi;
            this.pripro = c.pripro;
            this.pubpro = c.pubpro;
            this.propro = c.propro;
        }

         void Hi()
        {
            Console.WriteLine("Hi");
        }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        protected void Bonjour()
        {
            Console.WriteLine("Bonjour");
        }
    }
}
