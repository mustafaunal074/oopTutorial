namespace Ders11_Constructor
{
    class Program
    {
        private static void Main(string[] args)
        {
            new MyClass(5);
        }
    }

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("1. Contructor");
        }
        public MyClass(int a) : this()
        {
            Console.WriteLine($"2. Contructor : a = {a}");
        }
        public MyClass(int a,int b) : this(a)
        {
            Console.WriteLine($"3. Contructor : a = {a} | b = {b}");
        }

        
    }
    
}