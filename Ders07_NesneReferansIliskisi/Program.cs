namespace Ders07_NesneReferansIliskisi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new MyClass();

            // MyClass m = new MyClass(); // default değerli geldi aşağıda istediğimiz değerler ile değiştiridk
            // m.MyProperty = 10;
            // m.MyProperty2 = 20;
            // m.MyProperty3 = 30;
            MyClass m = new MyClass() // burda ise default gibi kendi istediğimiz değerler ile olşturduk.
            {
                MyProperty = 10,
                MyProperty2 = 20,
                MyProperty3 = 30
            };

        }
    }

    class MyClass
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }
}