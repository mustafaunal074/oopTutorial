# Ozel Keywordler ( this - base - readonly )

## this
* Bir sınıfın, uygulamanın herhangi bir noktasında üretilmiş instance'larını/object'lerini/nesne'lerini sınıfiçerisinde temsil etmemizi sağlayan bir keyword'dür.
* this keywordü, bir sınıf içerisinde bulunan birden fazla constructor overload'ı arasında zıplamamızı sağlayan    birkeyworddür.

```csharp
class MyClass
{
    public int MyProperty { get; set; }
    public MyClass()
    {
     
     MyProperty = 1; // ile aynı şeydir compiler arkada başına this. 'ior. thisi kullanmak zorunda değiliz yani
     // lakin şunuda unutmamak lazım eğer kis bir miras alıyorsa ve üst sınıftadaimde bir member var ise bunlarıse keywordleri ile ayırmakktedir.
    }
    public MyClass()
    {
        // this.MyProperty = 1; // => this oluşan sınıf içerisinde temsil ediyor.
        // MyProperty = 1; // =>  ile aynı şeydir compiler arkada başına this. 'ior. thisi kullanmak zorunda değiliz yani
        // lakin şunuda unutmamak lazım eğer ki bu class bir miras alıyorsa ve üst sınıftada aynı isimde bir member var ise bunları this-base keywordleri ile ayırmak gerekmektedir.
        Console.WriteLine("Boş constructor");
    }
    public MyClass(int a) : this()
    {
        Console.WriteLine("a parametreli constructor");
    }
    public MyClass(int a, string b) : this(3)
    {
        Console.WriteLine("a ve b parametreli constructor");
    }
}
new MyClass(3,"");
// resultu =>
    // Boş constructor
    // a parametreli constructor
    // a ve b parametreli constructor
    // şeklinde olacaktır.
```

---
## base

* base keyword'ü, bir instance'ın base class'ını sınıf modeli içerisinde temsil eden bir keyword'dür.
* base keyword'ü, base class'daki constructor'lardan seçim yapmamızı sağlar.

```csharp
class MyClass2 : MyClass
{
    public MyClass2() : base(3, "")
    {
        Console.WriteLine("Son constructor");
    }
}
new MyClass2();
// resut =>
    // base classtaki 
        //public MyClass(int a, string b) : this(3)
        //public MyClass(int a) : this()
        //public MyClass()
    // tetiklenir
    // sonra public MyClass2() tetiklenir.

    // Boş constructor
    // a parametreli constructor
    // a ve b parametreli constructor 
    // Son constructor
```

* Ek olarak üst sınıftaki membera erişmek için illa base keywordüne gerek yoktur(zaten compiler onu kendi elle ekliyor.) lakin isim benzerliği olanları ayrıt etmek için kullanmamaız gereklidir.

---

## readonly

* Bir class içerisinde tanımlanmış olan değişkenin yahut referansın sadece okunabilir olmasını sağlayan bir keyworddür.
* readonly keyword'ü ile işaretlenmiş olan referansların değerleri ya tanımlandığı anda ya da constructor'da verilebilir.

```csharp
class MyClass3
{
    readonly object x = 5;
    readonly object y;
    public MyClass3()
    {
        y = 10;
    }
}
```

* readonly keywordü ile işaretlenmiş bir değişkene başka bir yerde değer atanırsa compiler hata verecektir.
* const yapılanmalar, readonly ile karıştırılabilir. Aralarındaki fark şöyledir;
    * const tanımlandığı yerde değeri verilmelidir. ctor içerisinde bile değer ataması gerçekleştirilemez. Lakin readonlyde ister tanımlama noktasında ister senizde ctor içerisinde değer ataması gerçekleştirilebilir.
    * const static bir yapılanmadır.