using laba_1;

namespace laba1 {
    internal static class Program {
        public static void Main(string[] args)
        {
            C1 c1 = new C1();
            c1.pubpro = 12;
            C1 c11 = new C1(c1);
            Console.WriteLine(c11.pubpro);
            C1 c111 = new C1(1,2,3,4,5,6);
            Console.WriteLine(c111.pubpro);

            C2 c2 = new C2();
            c1.pubpro = 12;
            C2 c22 = new C2(c2);
            Console.WriteLine(c22.pubpro);
            C2 c222 = new C2(1, 2, 3, 4, 5, 6);
            Console.WriteLine(c222.pubpro);
            c2.arrs = new int[4];
            ((I1)c2)[0] = 1;
            Console.WriteLine(c2.arrs[0]);
            c2.deEv += c2.Hello;
            c2.No();

            C4 c4 = new C4();
            c1.pubpro = 12;
            C4 c44 = new C4(c4);
            Console.WriteLine(c44.pubpro);
            C3 c444 = new C4(1, 2, 3, 4, 5, 6);
            Console.WriteLine(c444.pubpro);
            c4.arrs = new int[4];
            ((I1)c4)[0] = 1;
            Console.WriteLine(c4.arrs[0]);
            c4.deEv += c4.Hello;
            c4.No();
        }
        }
}