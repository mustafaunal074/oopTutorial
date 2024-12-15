using System;
class MyClass2
{

}

namespace Ders02_Class
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Sinif Nedir ? Neden Sinif Yapisi    Kullanilir?

            // oop'de bir object oluşturabilmek için    öncelikle  objectin modellenmesi tanimlanmasi  gerekmektedir.
            // bir objenin modelini/taniminin olusturablmek     için class yapisi kullanilir.

            #endregion

            #region Sinif İle Nesne Arasindaki İlişki Nedir?

            // claslarda nesnelerdeki ortak alan tanimlari  yapilir.
            // sinif nesnelerin türetildiği yapıdır.
            // bir sinifin birden fazla nesnesi olabilir

            #endregion

            #region Sinif Nasil ve Nerede Oluşturulur

            // Classlar bir referans türüdür.
            // Sınıf 3 farklı yerde oluşturulur

            #region NameSpace İçerisinde



            #endregion
            #region NameSpace Disarisinda

            #endregion
            #region Class İçerisinde(Nested Type)

            #endregion

            // Bir class tanımlamasında tanımlanan yerde(namespace, namespace/dışı, class) aynı isimde birden fazla class tanimlanamaz!

            #endregion

            #region Sinif İle Nesne Modeli Tasarlama

            // İlk önce bir sınıf oluşturalım(OrnekModel)
            //

            #endregion

            #region Sinif Modelinden Referans Noktasi Oluşturma

            // referans, stackte tutulan ve heapteki herhangi bir nesneyi işaretleyebilme özelliğine sahip değişken türü 
            // işte biz buna değişken türü demiyoruz referans noktasi diyoruz

            // Bir class tanımlandığında o class adi bir türdür. Haliyle o türü kullanabilmek için direkt olarak class adını kullanmamız yeterlidir.

            OrnekModel w;
            #endregion
        }
    }
    class OrnekModel
    {
        int a;
        int b;
        public void X()
        {
            Console.WriteLine(a + " " + b);
        }
        public int Y()
        {
            return a * b;
        }
    }
    class MyClass
    {
        class MyClass3
        {
            
        }
    }
}