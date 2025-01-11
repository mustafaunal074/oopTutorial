# STATIC CONSTRUCTOR

* Bir sınıftan nesne üretilirken 'constructor'a nazaran ilk tetiklenen metot 'static constrctor'dır. Ardından constructor tetiklenir.
* yani yukarıya özetlersek
---
* Bir sınıfta nesne üretilirken ilk tetiklenen fonksiyon Static Constructor'dır.
* Amma velakin belirli bir duruma istinaden!
---
* ctor ilgili sınıftan herr nesne üretilirken tetiklenen fonksiyondur.
* static ctor ise ilgili siniftan __ilkkkk__ nesne üretilirken tetiklenen fonksiyonudr.

## Static Constructor Özellikleri
* static ctor'da geri dönüş değeri ve erişim belirleyicisi bildirilmez!
* overloading yapılmaz
* Bir sınıfın içerisinde sade ve sadece bir tane tanımlanabilir(yani parametre almaz!!!)
* İsmi sinif ismiyle ayni olacaktir.
* aşağıdaki gibi tanımlanır
```csharp
class MyClass
{
    public MyClass()
    {

    }
    static MyClass()
    {
        // static ctor
    }
}
```

* static ctor'un tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur.
* İlgili sınıf içerisinde herhangi bir static yapılanmanında tetiklenmesi static ctor'un tetiklenmesini sağlayacaktır
