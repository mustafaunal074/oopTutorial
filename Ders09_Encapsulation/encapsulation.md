# ENCAPSULATION

## Encapsulation Nedir? Bir Veriyi Neden Kapsülleriz ?

* Encapsulation, nesnelerimizde ki field'ların kontrollü bir şekikde dışarıya açılmasıdır.
* Bir başka deyişlei nesnelerimizi başkalarının yanlış kullanımlarından korumak için kontrolsüz değişime kapatmaktır.

## Encapsulation Nasıl Uygulanır? 

* C#'da encapsulation iki türlü uygulanmaktadır;
    * Metot ile Encapsulation
    * Property ile Encapsulation

## Eskiden Encapsulation Nasıl Uygulanırdı?

```csharp
class MyClass
{
    int a;
    public int AGet()
    {
        return this.a;
    }
    public void ASet(int value)
    {
        this.a = value;
    }
}
MyClass m = new MyClass();
m.ASet(15);
m.AGet();
Console.WriteLine(m.AGet());  // 15
```

## Property ile Encapsulation

```csharp
int a;
public int A
{
    get { return a; }
    set { a = value; }
}
MyClass m = new MyClass();
#region Eski
m.A = 123;
Console.WriteLine(m.A);
```


