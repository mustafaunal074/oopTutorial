namespace Ders14_StaticConstructor
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region MyClass 
            // new MyClass(); 
            // result => static ctor + ctor tetiklenecek
            // new MyClass();
            // result => ctor tetiklenecek
            #endregion

            var database1 = Database.GetInstance;
            var database2 = Database.GetInstance;
            var database3 = Database.GetInstance;

            database1.ConnectionString = "asfsgf";

            // bu yaptığımız singleton design pattern sayesinde tek bir nesnemiz oluşmuş oldu.
            // Eee bu haldede database1 nesnesi ile database2 ve database3 nesnesi aynı değerlere sahip
            // database1. e verdiğimiz connection stringte otomatikmen 3'ündede aynıdır.

        }
    }
    class MyClass
    {
        public MyClass()
        {
            // Bu sınıftan nesne üretilirken ilk tetiklenecek olan metottur.
            System.Console.WriteLine("MyClass ctoru tetiklenmiştir.");
        }
        static MyClass()
        {
            // Bu sınıftan ilk nesne üretilirken ilk tetiklenecek olan metottur.
            // Üretilen ilk nesnenin dışında birdaha tetiklenmez!
            System.Console.WriteLine("MyClass static ctoru tetiklenmiştir.");

            // static ctor'un tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur.
            // İlgili sınıf içerisinde herhangi bir static yapılanmanında tetiklenmesi static ctor'un tetiklenmesini sağlayacaktır

        }
    }
    #region Singleton Design Pattern

    // Bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir design pattern.

    class Database
    {
        static Database database;
        static public Database GetInstance 
        {
            get
            {
                return database;
            }
        }
        private Database()
        {

        }
        static Database()
        {
            database = new Database();
        }

        public string ConnectionString { get; set;}


    }
        
    #endregion
}