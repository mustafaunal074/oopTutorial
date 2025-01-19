namespace Ders23_PartialYapilanmalar
{
    internal class Program
    {
        private static void Main(string[] args)
        {   

        }
    }
    partial class MyClass
    {
        public MyClass()
        {
            X();
            Y();
            Z();
        }
        partial void X();
        partial void Y(); // tanım-declaration-beyanname
        partial void Z();
        partial void Y() // gövde-implementation-uygulama
        {
            Console.WriteLine("Y tetiklendi...");;
        }
    }
}