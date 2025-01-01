namespace Ders09_Encapsulation
{

    class Program
    {
        private static void Main(string[] args)
        {
            MyClass m = new MyClass();

            #region Eski
            // m.ASet(15);
            // m.AGet();
            // Console.WriteLine(m.AGet());       
            #endregion 
        
            m.A = 123;
            System.Console.WriteLine(m.A);
        }
    }
    class MyClass
    {
        int a;
        #region Eskiden Encapsulation Nasil Yapiliyordu?
        
        public int AGet()
        {
            return this.a;
        }
        public void ASet(int value)
        {
            this.a = value;
        }
        #endregion
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        
    }
}