# Abstract Class

## Abstract Class Nedir? Neden Kullanıyoruz?

* Nesne Tabanlı Programlama'nın önemli kavramlarından ve davranışlarından biri inheritance(kalıtım)'dır. Kalıtım sayesinde bizler sınıflar arasında hiyerarşik ilişkiler oluşturabilmekte ve nesneler içerisindeki elemanları miras yoluyla birbirlerine aktarabilmekteyiz.
* Böylece ortak işlevselliklere sahip olan sınıfları kalıtımsal davranışla şekillendirerk tekrarlı kod yazımını azaltmakta ve okunabilirlik ile yeniden kullanılabilirliği arttırabilmekteyiz.
* Abstract Class'ı, bu niyetle kullandığımız kalıtımsal davranışı daha farklı manevralarla kullanabilmek için düşünülmüş ve geliştirilmiş olan bir nesnel yapı olarak tanımlayabiliriz.

##### İyi güzel de hoca! abstract class ne yani şimdi?

* Abstract Class, özünde kalıtımsal davranış göstererk bir sınıf üzerinde implementasyonlar yapmamızı sağlayan özel bir yapılanmadır!
* Burda implementasyondan kastedilenin ne olduğunu dersimizin ileriki dakikalarında netleştireceğiz. Şimdilik odaklanacağımız nokta abstract class'ın varlık sebebidir. Abstract class, bizlere yarı somut bir sınıf vermektedir.
* Yarı somut sınıftan kastedilen ise içerisinde normal member'lar barındıabileceği gibi kenddisini uygulayan sınıflara zoraki uygulattırabileceği member'ların imzalarını barındıran bir yapılanmadır.

```csharp
abstract class MyClass
{
    public void X()
    {
        //..
    }
    public void Y()
    {
        //..
    }
    public int Z {get; set;}

    abstract public void W();
    abstract public int Q();
    abstract public int H {get; set;};
}
```

* X,Y ve Z normal birer member
* W,Q ve H ise kalıtımsal olarak bu abstract class'ı uygulayan sınıflara zoraki olarak uygulattırılacak member imzaları da tanımlanabilmektedir. 

* Yani abstract class denen bu yapı özünde normal sınıf member'larıyla birlikte bu abstract class'ı uygulayan sınıflara zoraki olarak uygulattıracak member imzaları da barındıran bir yapı!

---

* Yazılım süreçlerinde abstract class'ları kullanma nedeni herhangi bir ihtiyaca istinaden değildir! Abstract class'lar tercihen kullanılan yapılardır.
* Genellikle abstract class'lara direkt gereklilik olduğu bir durum hiçbir zaman söz konusu olmayacaktır. Ancak belirli durumlarda iradeli bir şekilde abstract class'lar ile davranış sergilemeyi tercih edebilr ve varsa sorunlarınız daha basitleştirici unsur olarak abstract class'ları kullanabiliriz.
* Şöyle ki, bir abstract class ile kalıtımsal olarak aktarmak istediğiniz davranışlarla birlikte zoraki olarak uygulatmak istediğiniz davranışları bir bütün olarak tasarlayabiliriz.
* Ve bu tasarıyı istediğiniz sınıflara uygulatarak hem kalıtımsal aktarımda bulunabilir hem de o sınıflar içerisinde zorunlu olarak ilgili davranışları tanımlatabiliriz.
* Böyle bir davranışın gerekli olduğu bir senaryoyu söylememiz pek mümkün değildir amma velakin bu tarz bir davranışı gerçekleştirebilmeniz için abstract class'lardan istifade edebilirsiniz.

## Abstract Class'ın Yapısal Özellikleri Nelerdir?

* Abstract Class'ın ilk bilinmesi gereken özelliği her ne kadar abstract olsa da özünde bir class'tır. Yani referans türlü bir yapılanmadır. Dolayısıyla abstract class türünden belleğin __stack__ bölgesinde bir referans noktası edinilebilir ve bu referansla __heap__'te ki uygun nesneler işaretlenebilir.

### Abstract Class ile Nesne Arasındaki İlişki

* Abstract Class'lar soyut yapılanmalar olduğu için yapısal olarak iradeli bir şekilde (new operatörü ile vs.) nesne üretilebilir bir tür değildir!

* new MyClass();
* Yani bu şekilde bir abstract class'tan nesne üretmeye çalışmak mümkün değildir.
* Lakin bu abstract class türünden bir nesne hiçbir zaman olamaz anlamına gelmemektedir.
* Kalıtımsal olarak bir abstract class herhangi bir sınıfa miras verdiği taktirde buradaki davranış şöyle olacaktır.
```csharp
abstract class MyClass
{
    ...
}
class MyClass2 : MyClass
{

}
```
* Yukarıdaki gibi kalıtımsal durumun söz konusu olduğu durumlarda __new MyClass();__ komutu ile MyClass2 isimli sınıftan bir nesne üretilirse eğer burada kalıtımsal hiyerarşinin gereği olarak abstrat class'ın da dahil normal class'ın nesneleri üretilecektir.
* İşte bu durumda abstract class'ların nesneleri de varlık göstermektedir.

### Abstract Class'ta Constructor Tanımlama

* Kalıtımsal durumlarda abstract class'ların nesneleri oluşturuluyorsa eğer bu constructor'ları tetikleniyor demektir! Haliyle bizler irademizle her ne kadar abstract class'lardan nesne üretemesekte, içerisinde constructor tanımlayabilir ve kalıtımsal süreçlerdeki üretilecek olan nesneyi yapılandırabiliriz.

```csharp
abstract class MyClass
{
    public MyClass()
    {

    }
}
```

## Tanımlama ve İnşa Etme Kurallarını Toparlayalım

* Abstract Classlar tanımlanırken şu kurallar geçerlidir;
    * Bir abstract class tanımlayabilmek için __abstract class_ keyword'ü kullanılır!
    * Bir abstract class içerisine member'lar bilinen kurallarıyla eklenebilir.
        * Normal metotlar ve property'ler eklenebilir,
        ya da
        * Bu abstract class'ı implement edece olan sınıflarda zoraki tanımlanmasını isteyeceğimiz member imzaları da eklenebilir. Bu imzalar, gövdeleri ilgili alt sınıflara bırakılacak şekilde __abstract__ keyword'ü ile işaretlenerek tanımlanmalıdır. Tabi abstract keyword'ü ile işaretlenmiş olan member'lar kendilerini uygulayan sınıflar tarafından erişileceği içn zoraki _public__ olmak zorundadır.
    * Bir abstract class'ı uygulayan sınıf içerisine normal member'lar direkt miras yoluyla aktarılırken, abstact ile işaretlenmiş olan meber'lar ise ilgili sınıf içerisinde override edilmek zorundadır.
```csharp
abstract class MyClass
{
    public void X()
    {
        //,,
    }
    public void X()
    {
        //,,
    }
    public int Z {get; set;}

    abstract public void W();
    abstract public int W();
    abstract public int H {get; set;}
}

class MyClass2 : MyClass
{
    override public void W()
    {
        //..
    }
    override public void Q()
    {
        //..
    }
    override public int H {get; set;}
}
```

* Abstract Class'ı uygulayan/implemente eden sınıflara terminolojik olarak __Concrete Class__ denir.
* Abstract Class içerisindeki abstract yapıların concrete class içerisindeki tanımları public olmak zorundadır.

## Abstract Class'ı Uygulamaktan Kastettiğimiz Nedir?

* Abstract Class'ın söz konusu olduğu durumlarda implementation yani 'uygulama' fiiliyatı mevzu bahistir. Ki bu durum sonraki derste göreceğimiz interface içinde geçerlidir.
* Peki nedir bu implementation?
* Implementation'ı abstract class'ın bir başka kalıtım vermesidir. Yani bir başka deyişle kalıtımsal bir ilişkinin olduğu bir durumda eğer ki base class bir abstract class ise biz oradaki durumu implementation olarak nitelendirmekteyiz.
* Implementasyon'dan kastedilen şudur ki, abstract class içerisinde tanımlanmış olan bazı imzaların kalıtımsal davranış neticesinde zoraki olarak alt sınıfa uygulattırılması ya da bir başka deyişle oluşturulmasıdır.


## Abstract Class'ın Abstract Class'tan Türemesi

* Bir abstract class, başka bir abstract class'a __miras__ verebilir.
* Burada dikkat ederseniz bir abstract class'ın başka bir abstract class'a miras vermesi implementation olarak nitelendirilmemektedir.
* Bu düpedüz bir kalıtımdır. Çünkü abstract class'lar içlerinde abstract olarak işaretlenmiş olan yapıları zoraki olarak sadece kendilerini uygulayan sınıflara uygulattırırlar, abstract class'lara değil!

## Abstract Class Referansı İle Nesneyi İşaretleme

* Bir sınıf üzerinde abstraction davranışını gerçekleştirirken ihtiyaçlar ve senaryosuna göre abstract class'lardan istifade ederek elverişli bir şekilde uygulayabilirsiniz.

## Abstraction Açısından Değerlendirelim

* Bir sınıf üzerinde abstraction davranışını gerçekleştirirken ihtiyaçlar ve senaryosuna göre abstract class'lardan istifade ederek elverişli bir şekilde uygulayabilirsiniz.

## Özetlersek...

* Bir sınıfın uyması gereken temel yapıyı tanımlamak için abstract class yapısını kullanabilir ve gerekli modellemeyi gerçekleştirebilirsiniz.
* Abstract class'lar, bir çeşit abstraction yapılanmasıdır. Davranışların var olduğunu garanti eder lakin davranışın implementasyonunu interface'ler de ki gibi zorunlu kılmaz!
* Abstract class'la, interface'ler ile concrete/normal class'lar arasında bir yapıdır.
* Abstract class'lar, birçok senaryo için geçerli olabilecek genel davranışlar sağlayabileceği ancak kimi senaryolar için ise özel davranışlarda barındırabileceği bir sözleşmedir.  
* Abstract class, doğrudan inheritance ve polimorfizm ile bağlantılı bir kavramdır. Özellikle inheritance olmaksızın abstract class kullanılamaz! Keza inheritance amaçlı kullanılan yapı abstract class ise o zaman oradaki ifadeye implementation denir.
* Abstract class'lar (interface'ler de aynı şekilde) loose coupling'i destekler.
* YANİ SONUÇ OLARAK ABSTRACT CLASS PEK GEREKLİ BİR ŞEY OLMASA DA FAYDALI BİR YAPIDIR DİYEBİLİRİZ. :)