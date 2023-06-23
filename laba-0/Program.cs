namespace laba0
{
    public abstract class C1
    {
        private string hello = "Hello";
        public string Hello { get { return hello; } set{ hello = value; } }
        
        public virtual void Func()
        {
            Console.WriteLine("Abstract class func");
        }
        public abstract void Method();
    }
    public class C2 : C1 
    {
        public override void Func()
        {
            Console.WriteLine("C2 class func");
        }

        public override void Method()
        {
            Console.WriteLine("Method");
        }
    }

    public class C3 : C1
    {
        public override void Method()
        {
            Console.WriteLine("Method2");
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            C1 c1 = new C3();
            c1.Func();
            c1.Method();
            c1 = new C2();
            c1.Func();
            c1.Method();
            Console.WriteLine(c1.Hello);

        }
    }
}