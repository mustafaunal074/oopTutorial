namespace Ders05_ThisKeywordu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region this Keywordu
            
            #region 1.Sinifin Nesnesini Temsil Eder
            
            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass();

            m1.X();
            m2.X();


            #endregion
            #region 2.Ayni İsimde Field İle Metot Parametrelerini Ayirmak İcin Kullanilir
                
            #endregion
            
            // this keywördü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
            // this kullanmak zorunda değiliz.
            // 
            
            #region 3.Bir Constructer'dan Baska Bir Constructer'i Çağirmak İcin Kullanilir

            // zamanı geldiğinde bu konuyu konuşacağız.

            #endregion
            
            #endregion
        }
    }
    class MyClass
    {
        #region Senaryo 1
        // public void X()
        // {
        //      this.X();
        // }  
        #endregion
        #region Senaryo 2
        // int a;
        // public void X(int a)
        // {
        //     // a => bu a metotun imzasındaki a dır
        //     // this.a => bu a classın fieldındaki a dır
        // }
            
        #endregion
        #region Senaryo 3
        int a;
        public void X()
        {

        }
        #endregion
    }
}
