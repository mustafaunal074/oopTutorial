# RECORD

## Record'ı Anlayabilmek İçin Ön Hazırlık(Init-Only Properties)

* C# 9.0'da, herhangi bir nesnenin propertylerine ilk değerlerinin verilmesi ve sonraki süreçte bu değerlerin değiştirilmemeisini garanti altına almamızı sağlayan Init-Only Properties Özelliği gelmiştir.
* Bu özellik sayesinde nesnenin sadece ilk yaratılış anında propertylerine değer atanmakta ve böylece iş kuralları gereği runtime'da değeri değişmemesi gereken nesneler için ideal bir önlem alınmaktadır.

* Init-Only properties, developer açısından süreç esnanında değiştirilmemesi gereken property değerlerinin - yanlışıkla - değiştirilmesinin önüne geçmekte ve böylede olası hata ve buglardan yazılımı arındırmaktadır.

* __Init Only Properties__ => elimizdeki propertyleri readonly yapar hemde nesnenin ilk yaratılış anındaki object initalizer dediğimz anda ilk değeri vermemizi sağlar.

![initOnlyPropertiesOrnek](../Ders00_Ekstralar/resimler/initOnlyPropertiesOrnek.png)
![initOnlyPropertiesOrnek2](../Ders00_Ekstralar/resimler/initOnlyPropertiesOrnek2.png)

---

## Init-Only Properties Tanımlama

* Init-Only Properties özelliğine 'init' keyword'ü eşlik etmektedir

![initOnlyPropertiesTanimlama](../Ders00_Ekstralar/resimler/initOnlyPropertiesTanimlama.png)

![initOnlyPropertiesTanimlama2](../Ders00_Ekstralar/resimler/initOnlyPropertiesTanimlama2.png)

---

## Records Nedir ?

![recordNedir](../Ders00_Ekstralar/resimler/recordNedir.png)

* Nesne ön plandaysa bu class, nesnenin değerleri ön plandaysa bu record'dur.

![recordNedir2](../Ders00_Ekstralar/resimler/recordNedir2.png)

![recordNedir3](../Ders00_Ekstralar/resimler/recordNedir3.png)

## Record Tanımlama

![recordTanimlama](../Ders00_Ekstralar/resimler/recordTanimlama.png)

## Record İle Class Arasındaki Fark Kritiği Yapalım

![recordVsClass](../Ders00_Ekstralar/resimler/recordVsClass.png)
![recordVsClass2](../Ders00_Ekstralar/resimler/recordVsClass2.png)

## With Expressions

![withExpressions](../Ders00_Ekstralar/resimler/withExpressions.png)
![withExpressions2](../Ders00_Ekstralar/resimler/withExpressions2.png)


