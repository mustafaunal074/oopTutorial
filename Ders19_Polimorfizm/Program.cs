namespace Ders19_Polimorfizm
{
    #region Part 1
    
    // class Program
    // {
    //     private static void Main(string[] args)
    //     {
    //         C c = new C();
    //         c.X();
    //         c.Y();
    //         c.Z();

    //         B b = new C(); // Bu nesnenin B türündeki davranışlarına erişebiliyoruz
    //         b.X();
    //         b.Y();

    //         A a = new C(); // Bu nesnenin A türündeki davranışlarına erişebiliyoruz
    //         a.X();

    //     }
    // }
    // class A 
    // {
    //     public void X() { }
    // }
    // class B : A
    // {
    //     public void Y() { }
    // }
    // class C : B
    // {
    //     public void Z() { }
    // }

    #endregion
    
    #region Part 2
    
    class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new();
            m.Topla(4,6);

            Arac a  = new Arac();
            a.Calistir();
            Taksi t = new Taksi();
            t.Calistir();

            Arac t2 = new Taksi();
            t2.Calistir();

            
        }
    }
    class Matematik
    {
        public long Topla(int s1, int s2)
            => s1 + s2;
        public long Topla(int s1, int s2, int s3)
            => s1 + s2 + s3;
        public long Topla(int s1, int s2, int s3, int s4)
            => s1 + s2 + s3 + s4;
    }
    class Arac
    {
        public virtual void Calistir()
            => Console.WriteLine("Araç Calisti...");

    }
    class Taksi : Arac
    {
        public override void Calistir()
            => Console.WriteLine("Taksi Calisti...");
        
    }

    #endregion


}