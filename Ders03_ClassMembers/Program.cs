namespace Ders03_ClassMembers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Class Members

            #region Field

            // Nesne içerisinde değer tutmamızı sağlayan alanlardır.

            MyClass m1 = new MyClass();// Nesne oluşturduk !!!
            System.Console.WriteLine(m1.a); 
            m1.a = 5;
            System.Console.WriteLine(m1.a);
            MyClass m2 = new MyClass(); 
            m2.a = 25;

            #endregion
            #region Property
                
            #endregion
            #region Metot
                
            #endregion
            #region Indexer
                
            #endregion
                
            #endregion
        }
    }

    class MyClass
    {
        public int a; // field
        public string b; // field
    }
}