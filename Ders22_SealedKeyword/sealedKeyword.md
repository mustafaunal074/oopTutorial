# Sealed Keywordü

## Sealed Keywordü Nedir?

* Bir sınıfın miras vermesini yahut bir başka deyişle başka bir sınıf tarafından miras alınmasını engelleyen bir keyword'dür.
* Sadece sınıflarda ve sadece 'override' edilmiş metotlarda kullanılabilir.

```csharp
sealed class A
{

}
```

## Metot Üzerinde sealed Keyword'ünün İşlevi

* Kalıtımsal durumlarda, atalardan gelen ve birinci dereceden alt sınıf tarafından 'override' edilmiş olan 'virtual' member'ların hiyerarşideki sonraki sınıflar tarafından 'override' edilmesini ilgili member'ı sealed ile işaretleyerek engelleyebiliriz.

```csharp
class A
{
    public virtual void X() 
    {
        Console.WriteLine("Merhaba A");
    }
}
class B : A
{
    public sealed override void X() 
    {
        // sealed keywördü ile virtual akışı iptal ederiz ve override edilme özelliğini kapatmış oluruz.
        // X methotu aktarılır ama override edilemez.
        Console.WriteLine("Merhaba B");
    }
}
class C : B
{
    
}
```

* Pratikte bu yöntem sayesinde üst sınıfın davranışını güvenli bir şekilde korumuş ve ilgili metodun değiştirilmesini önlemiş oluyoruz.

## sealed Keyword'ü Hangi Durumlarda Kullanılmalıdır?

* **<u>Sınıfların Davranışlarını Korumak İstediğimizde </u>** 
Kalıtımsal Hiyerarşide üst sınıfların özel metotları/davranışları varsa ve bu metotlardaki davranışların alt sınıflar tarafından değiştirilebilir olmasını istemediğimiz durumlarda, o metodu sealed olarak işaretleyebiliriz.
* **<u>Performans İyileştirmesi İstendiğinde</u>** 
Mikro seviyede yapılan bir optimizasyon neticesinde C#'ta bir sınıf sealed ile işaretlendiğinde sealed olmayan bir sınıfa göre ufak çapta bir performans artışı gösterdiği anlaşılmıştır. Bunun nedeni, derleyicinin sealed ile işaretlenmiş sınıfın miras alınamayacağını bilerek daha hızlı derleme yapmasıdır.
* **<u>Singleton Design Pattern</u>**
Singleton Design Pattern'da bir sınıfın uygulama çapında tekil bir instance'ının olması amaçlanmaktadır. Haliyle ilgili sınıf sealed ile işaretlenerek, bu sınıftan herhangi bir kalıtımsal ilişkinin yaratılmasını engelleyebilir ve tek instance üretimini daha da garanti hale getirmiş oluruz. 

## EK

* Java'da final keyword'ü C#'ta ki sealed keyword'ünün muadilidir.