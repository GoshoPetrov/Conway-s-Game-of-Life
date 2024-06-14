namespace ConsoleApp11
{

    public class A
    {
        public int AProp { get; set; }

    }

    public class B : Exception
    {
        public int BProp { get; set; }

        public B() : base("b message")
            
        {
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            A a = new A();
            B b = new B();

            var x = b.Message;
            throw new B();

        }
    }
}