# Çok Biçimlilik(Polimorfizm)

* Polimorfizm esasında kalıtım gibi bir biyolojik terimdir.

## Polimorfizm Nedir?

* OOP'de ise polimorfizm'e:
    * İki ya da daha fazka nesnenin aynı tür sınıf tarafından karşılanabilmesidir/referans edilebilmesidir.
diyebiliriz.
* Bir başka deyişle:
    * Bir nesnenin birden fazla farklı türdeki referans tarafından işaretlenebilmesi poliformizm'dir.
* Polimorfizm, bir nesnenin kalıtımsal olarak ilişkisi olan diğer nesnelerin referansıyla işaretlenebilmesini sağlar.
* Polimorfizm, OOP tasarımlarında geliştirilen koda daha manevrasal bir şekilde nitelik kazandıran ve yaklaşım sergilememizi sağlanyan bir özelliktir.
* Polimorfizm, programlamadaki eldeki nesnenin birden fazla referansla işaretlenebilmesini sağlarç
* Bir nesnenin, birden fazla referansla işaretlenmesi; o nesnenin, birden fazla türün davranışlarını gösterebilmesini sağlar.

## Polimorfizm Felsefesi - 1

* Kuş deyince aklımıza ne geliyor ?
    * Muhabbet kuşu
    * Papağan
    * Tavuk
    * Kartal
    * ...
* Farkınsaysak eğer, kuş deyince bu hayvanlardan biri aklımıza gelmes de özünde bunların kuş olduğunu görebilmekteyiz.
* Yani ben bir muhabbet kuşuna da Kuş diyebilmekteyim Yahut bir kartalada
* Dikkat edersek burada 'Kuş' kelimesi birden fazla hayvana karşılık gelebilmektedir.
* Yani kartal bir yandan Kartal iken bir yandan da Kuş'tur.
* Aynı şekilde Tavuk bir yandan Tavuk iken bir yandan Kuş'tur.
* İşte bu hayvanların kendi türlerinin dışında ortak olarak Kuş diye nitelendirilmeleri POLIMORFIZM'dir.
* Yani bir olguyu çoklu(poli) form(morfizmos) olarak tarif edebilmektedir.

** Yani Kuş cinsinden olan tüm hayvanların kendi türlerinin dışında bir yandan Kuş olarak tarif edilmeleri çok biçimliliktir...
** Peki kuş olmayan bir hayvana Kuş diyemeyirouz! Misal 'Maymun'. Bir 'Kuş' değildir! Buradan şöyle bir sonuca varabilir miyiz?
** Ortak atadan gelen, kalıtımsal olarak 'Kuş'tan türeyen tüm hayvanlar kendi türleri yahut 'Kuş' türü ile referans edilebilirler.
** Buradan da şunu anlıyoruz ki, yazılımsal açıdan çok biçimliliğin söz konusu olabilmesi için teknik olarak 'Kalıtım' olması gerekmektedir... Bunu dersin devamında daha detaylı göreceğiz..
** Bizler şimdi çok biçimliliğin felsefesine bir başka örnekle devam edelim..

## Poliforfizm Felsefesi - 2

* Yemek yiyen canlılar yediklerini sindiriler.
* şimdi bu cümlede Yemek yiyen canlılar yerine ne koyabiliriz ?
    * İnsan
    * İnek
    * Hindi
    * ...
* İşte görüldüğü üzere burada yemek yiyen canlılar yerine bir çok şey getirebilmekteyiz.
* Ve tüm bbu canlıların ortak özellikleri 'yediklerini sindirebilmeleri'.

## Poliformizm Felsefesi - 3

* Tavuk, tavuktur bir yandan bir kuştur
* Kartal, kartaldır. bir yandan da kuştur.

* Yani eşşeğe altın semer vursak eşşek yine eşşektir => Poliformizm

## Peki Programlamada Poliformizm Nerde Kullanılmaktadır ?

* Programlama da poliformizm esasında taa en temelden beri kullanılmaktadır.
* Misal olarak;
    * Elimizdeki herhangi bir byte türündeki veriyi ister byte istersekte byte'tan büyük olan herhangi bir türde tutmak çok biçimliliktir.
* Ya da objcet türünün herhangi bir türdeki değeri alabilmesi yahut bir başka deyişle object türüne herhangi bir türdeki veriyi atayabilemk poliformizm'dir.
* Misal;
    * string bir değer olan "mustafa" değerini ister 'objcet' türüyle referans edebilir istersekte 'string' türüyle işaretleyebiliriz. İşte burada da 'object' ve 'string'in aynı veriyi işaretleyebilmesi bir çok biçimlilik(Poliformizm) durumudur.
* Tabi çok biçimlilik dendiğinde temel programlamadaki bu durumlardan ziyade esas Nesne Tabanlı Programlama'da ki getirileri önemlidir!
* Haliyle Nesne Tabanlı Programlama'da bir nesneyi kendi türünün referansıyla birlikte farklı türdeki referanslarla işaretleyerek Poliformizm'i uygulayabilmekteyiz.

*** 

* Normal şartlarda bir nesne kendi sınıfının referansı dışında başka bir sınıfın referansıyla İŞARETLENEMEZ.
* Evet... Bir nesnenin bbaşka bir nesne ile işaretlenebilmesi/referans edilebilmesi için kesinlikle arada kalıtımsal bir ilişki olması gerekmektedir.
* Yani başka bir deyişle, Nesne Tabanlı Programlama'da Poliformizm uygulamak istiyorsanız türler arasında kalıtım uygulanmış olmalıdır.
* Ya da bam başka bir deyişle; Nesne Tabanlı Programlama'da Poliformizm aralarında kalıtımsal ilişki olan sınıflarda uygulanabilir. Aksisi mümkün değildir.

## Polimorfizm Kalıtım İlişkisi

* Bir nesneyi, kendi türünün dışındaki bir tür ile işaretleyebilmek için kesinlikle ilgili nesne, o türden türemiş olması gerekmektedir.
```csharp
class A
{

}
class B : A
{

}
B b = new B() // bu gayet normal
A a = new B() // bunun olabilmesi için B nin A dan türemsi gerekmektedir
```

* Yukarıdaki örnektede Eğerki B sınıfı A sınıfından türediği taktirde artık B sınıfı bir yandan da A sınıfı olacağı için B nesnesi A referansı tarafından işaretlenebilecektir.

* Başka bir öneğe bakalım
```csharp
class Insan
{

}
class Erkek : Insan
{

}
class Kadin : Insan
{
    
}

Erkek e = new Erkek();
Insan i = new Erkek();
// İşte erkek nesnensini insan ile işaretlenebilmesi
// poliformizmdir.
```

## Peki Polifromizm Bir Nesne Yönetiminde Neye Yarar?

* Daha önceden de söylediğimiz gib, Bir nesnenin birden fazla referansla işaretlemesi; o nesnenin, birden fazla türün davranışlarını gösterebilmesini sağlar.

## Genel Özet

* Poliforfizm, bir nesnenin kendi türünün dışında bir veya birden fazla türle işaretlenebilmesidir/ referans edilebilmesidir. Ve bunun bize getirmiş olduğu farklı davranışları sergileyebilme niteliğidir.