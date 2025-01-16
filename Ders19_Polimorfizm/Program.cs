namespace Ders19_Polimorfizm
{
    class Program
    {
        private static void Main(string[] args)
        {
            C c = new C();
            c.X();
            c.Y();
            c.Z();

            B b = new C(); // Bu nesnenin B türündeki davranışlarına erişebiliyoruz
            b.X();
            b.Y();

            A a = new C(); // Bu nesnenin A türündeki davranışlarına erişebiliyoruz
            a.X();

        }
    }
    class A 
    {
        public void X() { }
    }
    class B : A
    {
        public void Y() { }
    }
    class C : B
    {
        public void Z() { }
    }
}