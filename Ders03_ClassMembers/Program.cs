namespace Ders03_ClassMembers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Class Members

            #region Field

            // Nesne içerisinde değer tutmamızı sağlayan alanlardır.
            // Fieldlar başlangıçta kendi türününü default değerini alırlar

            // MyClass m1 = new MyClass();// Nesne oluşturduk !!!
            // System.Console.WriteLine(m1.a); // 0
            // m1.a = 5;
            // System.Console.WriteLine(m1.a); // 5
            // MyClass m2 = new MyClass(); 
            // m2.a = 25;

            #endregion
            #region Property
            
            MyClass myClass = new MyClass();
            // System.Console.WriteLine(myClass.Yasi);
            // myClass.Yasi = 65;
            // System.Console.WriteLine(myClass.Yasi);

            myClass.Yasi = 12;
            System.Console.WriteLine(myClass.Yasi);


            #endregion
            #region Metot
            // MyClass m2 = new MyClass();
            // m2.X();
            #endregion
            #region Indexer
                
            #endregion
            
            MyClass m2 = new MyClass();
            myClass[5] = 10;

            #endregion
        }
    }

    class MyClass
    {
         int yasi; // field
         string b; // field

        #region Full Property

        // Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır.
        // Propertyler temsil ettikleri field'ların isimlerinini baş harfi büyük olacak şekilde isimlendirilir

        // public int Yasi
        // {
            // get 
            // {
                // property üzerinden değer talep edildiğinde bu blok tetiklenir
                // yani değer buradan gönderilir yani return edilir
            //     return yasi;
            // }
            // Eğerki ilgili propertynin set bloğunu tanımlamazsak değer atama işlemi olmaz
            // set
            // {
            //     yasi = value;
            // }
        // }

            
        #endregion

        #region Prop Property
        
        // public int Yasi
        // {
        //     get
        //     {
        //         return yasi;
        //     }
        //     set 
        //     {
        //         yasi = value;
        //     }
        // }

        // public int Yasi { get; set; } // PROP PROPERTY
        // public int Yasi { get; } readonly olabilir. mantık değer atayabildiğim için başlangıçta birazdan görecez onun için readonly olabiliyor.
        // public int Yasi { set; } write only OLAMAZ. mantık yazdığım değeri kullanamayacaksam niye yazıyorum
        

        #endregion

        #region Auto Property Initializers
        
        public int Yasi { get; set; }  = 23; // Auto Property Initializers

        #endregion

        #region Ref Readonly Returns

        // bize yararı bellek optimizasyonu sağlıyor
        
        string adi  = "Mustafa Ünal";
        public ref readonly string Adi => ref adi;

        #endregion
    
        #region Computed Property

        int s1 = 5;
        int s2 = 10;
        public int Topla
        {
            get
            {
                return s1 + s2;
            }
            set
            {

            }
        }
            
        #endregion

        #region Metot

        public int X()
        {
            return 0;
        }
            
        #endregion

        #region Indexer
        
        public int this[int a]
        {
            get 
            {
                return a;
            }
            set 
            { 
                
            }
        }

        #endregion
    
    }
    class Banka
    {
        int bakiye;
        public int Bakiye
        {
            get
            {
                if(bakiye > 0)
                    return bakiye * 10/100;
                return 5;
            }   
            set
            {
                if (value < 10)
                    bakiye = value;
                else
                    bakiye = value * 95/100;    
            }
        }
    }
}