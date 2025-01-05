namespace Ders12_Destructor
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Ornek1
            
            // X();
            // GC.Collect(); // Garbage Collector devreye sokulmuş oldu !!! tavsiye edilmez...
            // Console.ReadLine();

            #endregion
            #region Ornek2
            int sayi = 100;
            while (sayi >= 1)
            {
                new MyClass2(sayi--);
            }
            Console.WriteLine("********************");
            GC.Collect();
            Console.ReadLine();
            #endregion
        }
        static void X()
        {
            MyClass m = new MyClass();

        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Nesne Üretilmiştir.");
        }
        ~MyClass()
        {
            Console.WriteLine("Nesne imha ediliyor...");
        }

    }
    class MyClass2
    {
        int no;
        public MyClass2(int no)
        {
            this.no = no;
            Console.WriteLine($"{no}. nesne oluşturulmuştur.");
        }
        ~MyClass2()
        {
            Console.WriteLine($"{no}. nesne imha edilmiştir.");
        }
    }
}