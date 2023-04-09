## Object Oriented Programming

Nesne Yönelimli Programlama (Object Oriented Programming), sınıflar ve nesneler kavramına dayanan bir programlama yaklaşımıdır. Bu yaklaşımın amacı, ihtiyaç duyulan programı daha küçük parçalara bölerek, yönetilebilir ve yeniden kullanılabilir hale getirmektir. Her küçük parçanın kendine ait özelliği, verileri ve diğer küçük parçalarla nasıl iletişim kuracağı bilgileri bulunur.

![oop](https://user-images.githubusercontent.com/78081616/230722329-8b5bec82-2b3b-484f-b510-cf0d47186b2b.png)

### 1. Encapsulation:
- Verilerin ve işlevlerin sınıflar içinde saklanması ve sınıf dışından erişimlerin kontrol edilmesi işlemidir.
- Bu prensip, sınıfın kendi içerisindeki yapısının dışarıya kapalı tutulması sayesinde sınıfın daha korunaklı, daha güvenli ve daha sürdürülebilir olmasını sağlar.

### 2. Inheritance:
- Bir sınıfın diğer sınıflardan özelliklerini devralması işlemidir.
- Bu prensip, kodun tekrarını önler, kodun yeniden kullanılabilirliğini arttırır ve nesneler arasında doğru hiyerarşik ilişkiler kurulmasını sağlar.
~~~csharp
class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}
~~~

### 3. Polymorphism:
- Aynı isme sahip işlevlerin farklı şekillerde davranabilmesini sağlayan bir prensiptir.
- Bu prensip, kodun esnekliğini arttırır, aynı işlevi tekrar tekrar yazmaktan kaçınmayı sağlar ve kodun daha okunaklı hale gelmesine yardımcı olur.
~~~csharp
class Animal  // Base class (parent) 
{
  public void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}
~~~
### 4. Abstraction:
- Karmaşık yapıların basitleştirilerek, yalnızca gerekli özelliklerin gösterilmesini sağlar. Eğer bir sınıf için nesne üretmek mantıksız geliyorsa o sınıf soyutlanabilir.
- Bu prensip, programcıların nesnelere yalnızca önemli olan özelliklere odaklanmalarını sağlar, kodun daha okunaklı ve daha anlaşılır olmasını sağlar ve kodun yeniden kullanılabilirliğini ve sürdürülebilirliğini arttırır.

Bu dört prensip, nesne yönelimli programlama yaklaşımının temel yapı taşlarını oluşturur ve birlikte kullanıldıklarında, daha esnek, okunaklı, sürdürülebilir ve genişletilebilir kodlar yazmaya yardımcı olurlar.

### Interface:
- Interface, sınıfların kullanacağı yöntem ve özelliklerin açık bir şekilde tanımlandığı bir şablon, arayüzdür.
- Kullanımı, kodun parçalara ayrılması sağlar ve yönetilmesini kolaylaştırır. Kod tekrarını engeller.

### Abstraction vs Interface:
| Abstract Class                          | Interface                                |
| ---------------------------------------| ---------------------------------------- |
| Constructor içerebilir.                | Constructor içeremez.                    |
| Static üyeler içerebilir.               | Static üyeler içeremez.                   |
| Farklı tipte erişim belirleyici içerebilir. | Erişim belirleyiciler kullanılmaz. Default olarak 'public' kabul edilir. |
| Sınıfın ait olduğu kimliği belirtmek için kullanılır. | Sınıfın yapabileceği kabiliyetleri belirtmek için kullanılır. |
| Bir sınıf sadece bir tane abstract sınıftan kalıtım alabilir. | Bir sınıf birden fazla interface'i kalıtım alabilir. |
| Türetilen sınıflar sınıfın hepsini veya bir kısmını da implement edebilir. | Interface'i tamamen implement etmek zorundadır. |

### Class:
- Class, nesne yönelimli programlamada nesnelerin özelliklerini ve davranışlarını tanımlamak için kullanılan bir şablondur. 

### Object:
- Nesne bir sınıfın instance'ıdır. Her nesne, sınıfın özelliklerini ve davranışlarını taşır.
- C#'ta bu şekilde türetilir:
~~~csharp
Car myObj = new Car(); 
~~~
- Unity'de bunun yerine GameObject kullanılır.

### Constructor:
- Constructor, bir sınıf türetildiğinde otomatik olarak çağrılan özel bir metottur. Bu yöntem, sınıfın özelliklerini ve davranışlarını tanımlar ve nesnelerin doğru şekilde oluşturulmasını sağlar.

## Keywords
### "this" Keyword:
- "this", Sınıfın kendisini ifade eden bir referanstır. Özellikle, sınıf içinde bulunan bir özellik veya metot ismi, aynı isimde başka bir yerde kullanıldığında karışıklıkları önlemek için kullanılır.

### "ref" Keyword
- "ref" bir değişkenin referans tipi olarak işaretlenmesini sağlar. Bu sayede, bu değişken bir metoda argüman olarak geçirildiğinde, metot içinde yapılan değişiklikler orijinal değişkeni de etkiler.
~~~csharp
void Increase(ref int num)
{
    num++;
}
~~~

### "sealed"
- Kalıtım alınması istenmeyen sınıfa yazılır.
~~~csharp
sealed class Vehicle 
{
  ...
}
~~~

### Field & Property
~~~csharp
public class Person 
{
    private string name; // field

    public string Name // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
}
~~~

### "Abstract void" vs "Virtual void"
- Abstract void, alt sınıfların tanımlanan metodu mutlaka uygulaması gerektiğini belirtir.
- Virtual void ise alt sınıfların tanımlanan metodu değiştirmeyi seçebileceği bir metottur.
~~~csharp
public abstract class E
{
    public abstract void AbstractMethod(int i);

    public virtual void VirtualMethod(int i)
    {
        // Default implementation which can be overridden by subclasses.
    }
}

public class D : E
{
    public override void AbstractMethod(int i)
    {
        // You HAVE to override this method
    }
    public override void VirtualMethod(int i)
    {
        // You are allowed to override this method.
    }
}
~~~
