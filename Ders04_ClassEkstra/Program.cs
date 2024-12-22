namespace Ders04_ClassEkstra
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Class İçerisinde Tanimlanan Class Sinif Elemani midir ?

            // Değildir !!!!
            
            // MyClass m1 = new MyClass();
            // MyClass.MyClass2 m2 = new MyClass.MyClass2();


            #endregion
            #region Class Elemanlarina Açiklama Satiri Nasil Eklenir ?

            Random random = new Random();
            random.Next();

            MyClass myClass = new MyClass();
            myClass.MyProperty = 4;
            myClass.X();
            myClass.X(4);


            #endregion
        }
    }

    /// <summary>
    /// Bu bir örnek classtır.
    /// </summary>
    class MyClass
    {
        int a; // field => class elemanı
        /// <summary>
        /// Bu bir propertydidir.
        /// </summary>
        public int MyProperty { get; set; } // prop => class elemani
        /// <summary>
        /// Bu bir örnek metotur
        /// </summary>
        public void X() {} // metot => class elemani
        /// <summary>
        /// Bu bir overload olan metot örneğidir
        /// </summary>
        /// <param name="a"> a parametresi</param>
        public void X(int a) {} 
        public int this[int a] { get { return 0;}  } // indexer => class elemani

        public class MyClass2
        {
            // NESTED CLASS'LAR CLASS MEMBERS DEĞİLDİR.
        }
    }
}
