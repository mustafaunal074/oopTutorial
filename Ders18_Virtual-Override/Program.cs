namespace Ders18_VirtualOverride
{
    class Program
    {
        private static void Main(string[] args)
        {
            
        }
    }

    #region Ornek 1
    
    class Obje
    {
        public virtual void Bilgi()
        {
            Console.WriteLine("Ben bir objeyim...");
        }
    }
    class Terlik : Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("Ben bir terliğim....");
        }
    }
    class Kalem : Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("Ben bir kalemim....");
        }
    }

    #endregion

    #region Ornek 2

    class Memeli
    {
        public virtual void Konus()
        {
            Console.WriteLine("Ben konuşmuyorum...");
        }
    }
    class Maymun :Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben maymunum ...");
        }
    }
    class Inek : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben ineğim ...");
        }
    }
        
    #endregion

    #region Ornek 3
    
    class Sekil
    {
        // Protected ile işaretlenmiş bir member sade ve sadece ilgili sınıfta yahut o sınıftan kalıtım almış olan sınıfların içerisinde erişilebilir. AMMA velakin nesne üzerinden erişilemez.
        protected int _boy { get; set; }
        protected int _en { get; set; }
        public Sekil(int boy,int en)
        {
            _boy = boy;
            _en = en;
        }
        public virtual int AlanHesapla()
        {
            return 0;
        }
    }
    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy,en)
        {
            
        }
        public override int AlanHesapla()
        {
            return _boy * _en / 2;
        }
    }
    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy,en)
        {
            
        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
    class Dikdortgen : Sekil
    {
        public Dikdortgen(int boy, int en) : base(boy,en)
        {
            
        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }


    #endregion

}