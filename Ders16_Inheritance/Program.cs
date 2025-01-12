namespace Ders16_Inheritance
{
    #region Part 1
    
    // class Program
    // {
    //     private static void Main(string[] args)
    //     {
    //         Muhasebeci muhasebeci = new Muhasebeci();
    //         Mudur mudur = new();
    //         Yazilimci yazilimci = new();
    //     }
    // }
    // class Personel
    // {
    //     public string Adi { get; set; }
    //     public string Soyadi { get; set; }
    //     public bool MedeniHal { get; set; }
    // }

    // class Muhasebeci : Personel
    // {
    //    public bool Musavir { get; set; } 
    // }
    // class Yazilimci : Personel
    // {
    //     public string[] KullandigiDiller { get; set; }
    // }
    // class Mudur : Personel
    // {

    // }

    #endregion
    #region Part 2
    
    class Program
    {
        private static void Main(string[] args)
        {
            // new D();
            // result aşağıdaki gibidir
            // A nesnesi oluşturulmuştur
            // B nesnesi oluşturulmuştur
            // C nesnesi oluşturulmuştur
            // D nesnesi oluşturulmuştur

            // yani atalardan başlar ilgili nesne üretimine gelecektir.
        }
    }
    #endregion

    class A
    {
        int a;
        public int b;
        public int MyProperty { get; set; }
    }
    class B : A
    {
        int c;
        public void X()
        {
            
        }
    }

    #region base keywordu Kullanimi
    
    // class MyClass
    // {
    //     public MyClass()
    //     {

    //     }
    //     public MyClass(int a)
    //     {

    //     }
    //     public MyClass(string a)
    //     {

    //     }
    //     public MyClass(int a, string b)
    //     {

    //     }
    // }
    // class MyClass2 : MyClass
    // {
    //     public MyClass2()
    //     {
    //         // Eger ki base class'ta boş parametreli bir constructor varsa derived classta base ile bir bildirimde bulunmak zorunda değiliz.
    //         // Çünkü varsayilan olarak kalitimsal durumda base classta ki bos parametreli constructor tetiklenir.
    //     }
    //     // public MyClass2() : base(5)
    //     // {

    //     // }
    //     public MyClass2(int a) : base(a)
    //     {

    //     }
    // }

    #endregion
    
    #region Aile İliskisi

    // class BuyukBaba
    // {

    // }
    // class Baba :BuyukBaba
    // {

    // }
    // class Anne : BuyukBaba
    // {

    // }
    // class Ogul : Baba
    // {

    // }
        
    #endregion

    #region Nesne Üretim İliskisi

    // class A
    // {
    //     public A()
    //     {
    //         Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur");
    //     }
    // }
    // class B : A
    // {
    //     public B()
    //     {
    //         Console.WriteLine($"{nameof(B)} nesnesi oluşturulmuştur");
    //     }
        
    // }
    // class C : B
    // {
    //     public C()
    //     {
    //         Console.WriteLine($"{nameof(C)} nesnesi oluşturulmuştur");
    //     }
    // }
    // class D : C
    // {
    //     public D()
    //     {
    //         Console.WriteLine($"{nameof(D)} nesnesi oluşturulmuştur");
    //     }
    // }
        
    #endregion

}