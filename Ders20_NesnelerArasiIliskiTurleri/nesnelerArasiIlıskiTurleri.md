# Nesneler Arasi İlişki Türleri

* Nesneler arasında terminolojik olarak nitelebdirilebilir ilşki türleri mevcuttur. Bu ilişkiler; kalıtım, referans yahut soyutlama gibi durumların getirisi olan mantıksal izahetlerdir.
* Nesneler arası ilişki türleri : 
    * is - a ilşkisi
    * has - a ilşkisi
    * can - do ilşkisi

## is - a İlişkisi Nedir ?

* is - a ilişkisi tamamıyla kalıtımla alakalıdır. C# programla dilinde, iki sınıf arasında __:__ operatörü ile gerçekleştirilen kalıtım neticesinde ortaya bir is - a ilişkisi çıkmaktadır.
* is - a ilişkisi için terminolojik oalrak söylemek için türeme işlemi olması gereklidir.
```csharp
class Araba
{

}
class Opel : Araba
{

}
// Oper bir arabadır.
```
```csharp
class Hayvan
{

}
class Inek : Hayvan
{

}
// Inek bir hayvandır.
```

## has - a İlişkisi Nedir?

* Bir sınıfın başka bir sınıfın nesnesine dair sahiplik ifadesinde bulunan ilişkidir. Bir yandan kompozisyon/composition ilişkisi de denmektedir.
```csharp
class Araba
{

}
class Opel : Araba
{
    Motor Motor;
}
class Motor
{

}
// Oper bir arabadır.(is - a)
// Opelin bir motororu vardır.(has - a)
```
```csharp
class Personel
{

}
class Sekreter : Personel
{
    Bilgisayar Bilgisayar;
}
class Bilgisayar
{

}
// Sekreter bir personeldir.(is - a)
// Sekreterin bir bilgisayarı vardır.(has - a)
```

## can - do İlişkisi Nedir?

* Sonraki derslerimizde göreceğimiz interface yapılanmasının getirisi olan bir ilişki türüdür.
* Tabi ki de can - do ilişkisini anlayabilmek için öncelikle interface yapılanması hakkında fikir sahibi olunması gerekmektedir.
* Kısaca interface; bir sınıfın imzasıdır. Yani bir sınıfın içerisinde olacak olan tüm member'ların şablonunu/arayüzünü oluşturduğumuz bir kontrattır. Herhangi bir interface'i uygulayan class o interface içerisinde tanımlanmış member imzalarını kendisinde oluşturmak zorundadır. Aksi taktirde compiler hata verecektir. Velhasıl tüm bunları a'dan z'ye ilgili konuya ait dersimizde tam teferruatlı incelenmiş olacağız.

* Interface'ler içerisindeki member'ların imzalarını class'lara uygulattırdığından dolayı o interface'ler ilgili nesnelerin yapabilecekleri kabiliyetleri göstermektedir.
* Yani can - do ilişkisi bir nesnenin davranışlarını/kabileyetlerini belirtmektedir.
* Bu davranış/kabiliyetlerin interface içerisinde tanımlanmaktadır.

```csharp
interface IAraba
{
    void Gazla();
    void Frenle();
}
class Opel : IAraba
{
    public void Gazla()
    {
        //...
    }
    public void Frenle()
    {
        //...
    }
}
```

* Hmm, demek ki bu interface'i uygulayan sınıflar gazlayabiliir ya da frenleyebilir...


## Association Nedir?

* Association, sınıflar arasındaki bağlantının zayıf biçimine verilen addır.
* Bu bağlantı oldukça gevşektir. Yani, sınıflar kendi aralarında ilişkilidir lakin birbirlerinde de bağımsızdırlar!
* Parça - bütün ilişkisi yoktur!
* Örneğin; bir otobüsteki yolcular ile otobüs arasındaki ilişki Associatın'dur. Nihayetinde hepsi aynı yöne gitmektedir. Lakin bir yolcu indiğinde otobüsün ve diğer yolcuların durumunu değiştirmez.

## Aggregation ve Composition Nedir?

* Nesneleri birleştirip daha büyük bir nesne yapmaya verilen isimlerdir.
* Yani her ikisi de birleştirilmiş nesnelerden bütünsel nesnler yapma durumlarını ifade eder.
* Her ikisinde de Association'da olmayan parça - bütün ilişkisi söz konusudur.
* Her ikisinde de sahiplik ilişkisi(has - a) vardır.

##### İkisinin arasındaki fark nedir o halde ?

| **Aggregation**                                                                                           | **Composition**                                                                                         |
|----------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|
| Sahip olunan nesnenin, sahip olan nesneden bağımsız bir şekilde var olabilmesi durumudur.                | Sahip olunan nesnenin, sahip olan nesneden bağımsız bir şekilde var olamaması durumudur.               |
| **Misal:** Bir arabayı düşünürsek, eğer, bu arabanın tekeri ile vitesi arasındaki ilişki Aggregation ya da Composition açısından değerlendirilirse eğer; bu araba teker olmadan olmaz lakin teker araba olmadan da kendi başına ayrı olarak var olabileceğinden dolayı **araba ile teker** arasındaki ilişki Aggregation'dır. | **Misal:** Benzer mantıkla bu araba vites olmadan da olmaz lakin vites araba olmadan bir anlam ifade etmeyeceğinden dolayı **araba ile vites** arasındaki ilişki Composition'dır. |
| **Başka bir misal:** Bir kitap sayfalardan ve kapaktan meydana gelmektedir. Kitapla sayfa ve kapak arasındaki ilişkiyi değerlendirirsek eğer; kitabın herhangi bir sayfasının yırtılması işlevselliği kaybettireceği aşikar. Lakin her bir sayfa başlı başına bağımsız bir şekilde var olabileceğinden dolayı **kitapla sayfa** arasındaki ilişki Aggregation'dır. | **Başka bir misal:** Kapak ise kitapla bir anlam kazanmaktadır ve kitabın dışında bağımsız bir şekilde var olmasının bir izahı yoktur. Dolayısıyla **kitapla kapak** arasındaki ilişki Composition'dır. |

## Aggregation vs Composition Orneği - 1

* İnşa edilen bir duvarda; tuğlalar, çimento ve usta ile duvar arasında nasıl bir ilişki vardır?

#### Duvarla tuğla arasındaki ilişki
* Duvar, tuğlalardan örülmektedir. Yani tuğlaların bir araya gelmesiyle oluşur. Haliyle tuğla olmadan duvar olmaz! Amma velakin, tuğla tek başına bir anlam ifade edebilmektedir. Nihayetinde bir tuğlayı duvar örmenin dışında farklı noktalarda da kullanabiliriz. O yüzden duvarla tuğla arasındaki ilişki Aggregation'dır.

#### Duvarla çimento arasındaki ilişki
* Duvar, çimento olmadan örülemez. Lakin çimento da duvar örmenin dışında tek başına bir anlam ifade etmez!(öyle kabul edelim) Bu sebeptan dolayı duvarla çimento arasındaki ilişki Composition'dır.

#### Duvarla usta arasındaki ilişki
* Duvar ile usta arasında parça - bütün ilişisi yoktur. Duvarı herhangi bir usta örebilir. Haliyle duvar ile usta arasındaki ilişki de sıkı bağlılık olmadığından dolayı Association'dır.

## Aggregation vs Composition Orneği - 2

* Bir arabanın gövdesiyle motoru arasındaki ilişkiyi ele alırsak

* Araba ve motor arabanın birer parçasıdır.
* Dolayısıyla burada bir sahiplik ve parça - bütün ilişkisi söz konusudur.
* Böylece __Association__ ilişkisini eliyoruz.
---
* Arabanın gövdesini incelersek eğer bir arabanın olmazsa olmazıdır.
* Ve bir gövde araba olmadığı sürece tek başına br anlam ifade etmez!
* Haliyle araba ile gövdesi arasında __Composition__ bağ vardır
---
* Şimdi de motoruna göz atarsak eğer bu da bir arabanın olmazsa olmazıdır.
* Lakin motor, araba olmadan da var olabilen ve ihtiyaç doğrultusunda farklı noktalarda kullanılabilen bir yapıdır.
* Dolayısıyla motor ile araba arasındaki ilişki ise __Aggregation__'dır.
---
* Peki bu arabaya bir sürücü oturttursak ne olur?
* Sürücü arabayı oluşturan bir parça olamdığı için, yani araba ile sürücü arasında parça - bütün ilişkisi olmayacağından dolayı Association ilişki söz konusudur.



