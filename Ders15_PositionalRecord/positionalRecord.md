# Positional Record

## Positinoal Record Nedir?

* Norminal Record'lar Object Initializer'lar ile ilk değerleri verilerek üretilebilen readonly datalardi.
* Positinal Record'lar ise esasinda Record'lar içerisinde tanimlama yapabildiğimiz constructor ve deconstructor kullanimlarini daha da özelleştirererk kullanilmasını sağlamaktadirlar.

```csharp
record MyRecord(string name, string surname)
{
    
}
```
* bu semantik positional record özelliğidir.
* bir record üzerinde constructor ve deconstructor yapılanmasını hizli bir sekilde olusturmamizi sağlayan bir semantik sağlanmaktadir.
* PR kullanirken parametrelerin karşılıkları olan propertyleri manuel olusturmak zorunda DEGILIZ.
* Bu parametrelin karşılığı olarak compiler seviyesinde propertyler otomatik oluşrurulacaktir.
* Bu propertyler oluşturulurken __init__ olacak şekilde oluşturulur.
---
## PEKİ BEN P.R KULLANIRKEN CTOR TANIMLAYABİLİR MİYİM ?

* Positional Record tanımlanmışsa eğer nesne üreitiminde tetiklenimesi/kullanılması ZORUNLUDUR!!!
* Peki o zaman nasıl kullancaz cevap basit __this__ keywordü ile

```csharp
record MyRecord(string name, string surname)
{
    public MyRecord() : this("asdas","asdfds")
    {

    }
    public MyRecord(string name) : this()
    {

    }
    // propbertyi aşağıdaki gibi oluşturabiliriz
    public string Name => name;
    public string Surname => surname;
}
```

