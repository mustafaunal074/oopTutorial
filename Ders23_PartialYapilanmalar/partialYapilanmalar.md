# Partial Yapilanmalar

## Partial Yapilanmalar Nelerdir?

* Bir class'ın, struct'ın yahut interface'in aynı yahut farklı dosyalarda birden fazla parçasının tasarlanmasını lakin bu parçaların özünde bir bütün olarak kullanılmasını sağlayan, kodun daha organize ve kolar okunabilirliğin arttıran özelliklerdir.
```csharp
namespace Y;            namespace Y;
partial class X         partial class X 
{                       {

}                       }
```
* Bu formatlar fiziksel olarak farklı olsalar da compiler açısından bir bütünün parçasıdır.
* Yani bu sınıftan bir nesne üretilimeye çalışıldığı zaman özünde tek bir nesne üretilecektir.
* Bu tanımlar ister aynı ister farklı dosya içerisinde tanımlanabilir.
* Tabi unutmamak lazımdır ki, fiziksel olarak farklı olan bu tanımların birbirlerinin parçaları olabilmesi için aynı namespace içerisinde, aynı isimde ve aynı yapıda olmaları gerekmektedir.

## Partial Yapılanmaların Kullanım Amaçlarıi

* Partial yapılanmaları genellikle aşağıdaki amaçlar doğrultusunda tercih etmekteyiz.
    * **<u>Kod Bölümleme</u>**
    Büyük ve karmaşık yapıdaki sınıfları daha okunabilir ve düzenlenebilir parçalara bölmek için kullanılabilir.
    * **<u>İş Bölümü</u>**
    Ekiplerin, aynı sınıfın farklı kısımlarını aynı anda geliştirebilmeleri için kullanılabilir.
    * **<u>İş Bölümü</u>**
    Code Generator sistemleri tarafından yazdığınız kodun ezilmemesi için kullanılabilir.

## Partial Yapılanmalarda Kısıtlamalar Nelerdir?

* Partial yapılanmalarda aşağıdaki kısıtlama durumları söz konusu olabilir;
    * Parça olması amaçlanan tüm yapılar partial keyword'ü ile işaretlenmelidir.
    ```csharp
    partial class MyClass
    {
        public void A()
        {

        }
    }
    partial class MyClass
    {
        public void B()
        {

        }
    }
    MyClass m = new MyClass();
    m.A();
    m.B();
    ```
    * İç içe partial türler kullanılabilir.(nested yapılar)
    ```csharp
    partial class MyClass
    {
        partial class MyClass2
        {

        }
    }
    partial class MyClass
    {
        partial class MyClass2
        {
            
        }
    }
    MyClass.MyClass2 m = new MyClass.MyClass2();
    ```
    * Tüm partial yapılar aynı namespace altında bulunmalıdır. Farklı projeler yahut modüllere yayılamaz.
    * partial olan bir yapının tüm parçalarının türleri ve isimleri aynı olmak zorundadır.

## Partial Olabilen Yapılar

* class
* record
    ```csharp
    partial record MyRecord
    {

    }
    partial record MyRecord
    {

    }
    ```
* abstract class
    ```csharp
    abstract partial class MyClass
    {

    }
    abstract partial class MyClass
    {

    }
    ```
* interface
    ```csharp
    partial interface IInterface
    {

    }
    partial interface IInterface
    {
        
    }
    ```
* struct
    ```csharp
    partial struct c
    {

    }
    partial struct c
    {
        
    }
    ```

## Partial Metotlar Nelerdir?

* Partial yapılar, partial metotlar barındırabilirler
* Partial metotlar, sınıfın bir parçasında geliştiricinin metot bildiriminde bulunmasını sağlar. Başka bir parçasında ise diğer geliştiricinin metot bildiriminde bulunmasını sağlar. Başka bir parçasında ise diğer geliştirici tarfından bu metot tanımlanabilir. Bunun yararlı olduğu iki senaryo vardır.

    * **<u>Template Code</u>**
        * Geliştirilen kodda metotlara dair şablon oluşturmak için kullanılabilir
        * Bu şablonların uygulanıp uygulanmayacağına dair geliştiricinin karar vermesine olanak tanınır.
        * Eğer sablonu tanımlanan metot uygulanmazsa derleyici tarafından metodun imzası ve o metoda dair yapılan tüm çağrılar/tetiklemeler kaldırılır.
        * Yani anlayacağınız, partial bir metot tanımlandığı taktirde ister uygulansın ister uygulanmasın herhangi bir farklı noktadan çağrılabilir/tetiklenebilir. Ancak uygulanmadığı taktirde herhangi bir derleme yahut çalışma zamanı hatası alınmayacaktır.
    * **<u>Source Generator</u>**
        * Source generator sistemleri ile sınıflarda tanımlanmış olan partial metot imzalarına karşılık gövdeler oluşturulabilir.
        * Geliştirici, uygulanacak metodun partial bir şekilde şablonunu ekledikten sonra source generator derleme sırasında bu metodun uygulanmasını sağlar.
        * Tabi geliştirici isterse, bu metotların gövdeleri source generator tarafından üretilmeden önce ya da bir başka deyişle bu metotlar uygulanmadan önce başka bir noktada çağrılabilir/tetikleyebilir.

## Partial Metot Kuralları
* Partial metotlarla ilgili aşağıdaki ekstra bilgileri bilmekte fayda vardır;
    * partial metotların runtime'da var olacağı kesin değildir. Eğer implementation edilmedilerse partial metotlar derleme sırasında yok sayılırlar.
    * Yukarıdaki durumdan dolayı partial metotlar delegate'ler ile temsil edilemezler.
    * partial metotlar;
        * ancak partial yapılar içerisinde tanımlanabilirler
        * geri dönüş tipleri her daim void olmak zorundadır.
        * static ve generic olabilirler.
        * out parametresi alamazlar lakin ref parametresi alabilirler.
        * extern ve virtual olamazlar.
    * Aynı class'lar da olduğu gibi partial metodun hem tanımı hem de gövdesi partial ile işaretlenmelidir.
    * Bir metot imzasına karşılık tanım ve gövde olabilir.
    * Eğer ki partial metotlar başka bir metot tarafından çağrılırlarsa compiler tarafından var oldukları bilinecektir. Yok eğer çağrılmazlarsa compiler derleme aşamasıdna ilgili metodu hiç görmeyecektir.
    * partial metotlar gövdeleri tanımlandığı halde pbulic olarak işaretlenebilirler.