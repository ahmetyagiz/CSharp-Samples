# "const", "static" ve "readonly"

Kelime | Tanım
------ | ------
const | Bir değişkenin sabit olduğunu ve değiştirilemez olduğunu belirtir. Tanımlama anında bir değer atanır ve bu değer daha sonra değiştirilemez.
static | Bir sınıfın örneği olmadan kullanılabilen bir özelliktir. Her sınıfın bir statik alanı vardır ve statik alan, tüm örnekler arasında paylaşılır.
readonly | Bir değişkenin sadece bir kez atanabileceği anlamına gelir. Değer, sadece bir kez atanır ve sonrasında değiştirilemez.

Const ve readonly anahtar sözcüğü, bir alanı sabit hale getirmek için kullanılır; bu değer değiştirilemez. Static anahtar kelimesi, üyelerin tüm sınıf nesneleri tarafından paylaşılabilecek static olmalarını sağlamak için kullanılır. Bu yazıda, bu üç arasındaki farkı anlayacağız.

Şimdi C#’daki const, readonly ve static değişkenler arasındaki farkın ne olduğunu ve bu anahtar kelimelerin her birini ne zaman kullanmamız gerektiğini öğrenelim.

## Constant
Constant alanlara veya local (yerel) değişkenlere bildirim sırasında bir değer atanmalıdır ve bundan sonra değerleri değiştirilemezler. Varsayılan olarak Constant’lar static’tir, dolayısıyla Constant bir tipi static olarak tanımlayamazsınız.

Const (uzunca okunuşu: constant) olarak bildirilen bir değişkene bildirimde (tanımlama anında) bir değer atanmalıdır ve bu değer daha sonra değiştirilemez.

~~~csharp
public const string ConnectionString = "YourConnectionString";
~~~

Bir const değişkenindeki değer, “compile-time (derleme zamanı)” değeri olarak adlandırılan değerdir ve değişmezdir (program ömrü boyunca değişmez).

Yalnızca primitive (ilkel) veya built-in (yerleşik) C# tiplerinin (örneğin, int, string, double) const ilan edilmesine izin verilir. Bu nedenle, aşağıdakilerden herhangi birini yazamazsınız:

~~~csharp
public const DateTime DateOfFoundation = new DateTime(1923,10,29);
public const MyClass MyValue = new Class() {Name = "TestName"};
~~~

Uygulamanız kullanılırken değeri hiç değişmeyecek bir değişkeniniz olduğunda const kullanmak istersiniz. Ayrıca, const olarak bildirilen herhangi bir değişken, dolaylı olarak static olarak da bildirilecektir.
Bir const alanı compile-time (derleme zamanı) sabiti olduğunu söyledik. Sabit bir alan veya yerel değişken derleme zamanında tamamen değerlendirilmesi gereken sabit bir ifade ile başlatılabilir.

~~~csharp
void Hesapla(int Z)
{
   const int X = 10, X1 = 50;
   const int Y = X + X1; //hata yok, derleme zamanı (compile time) değerlendirildiğinden
   const int Y1 = X + Z; //çalışma zamanında (run time) değerlendirildiğinde hata verir
}
~~~

Const anahtar sözcüğünü yerleşik değer türlerine (yani built-in value types) (byte, short, int, long, char, float, double, decimal, bool), enum, bir dize değişkeni (string literal) veya null ile atanabilecek bir reference türüne uygulayabilirsiniz.

~~~csharp
const BenimSinifim obj1 = null; //hata yok, derleme zamanı değerlendirildiğinden
const BenimSinifim obj2 = new BenimSinifim(); //çalışma zamanında değerlendirildiğinden hata verir
~~~

Const’lar public, private, protected, internal veya protected internal erişim değiştiricileri (access modifiers) olarak işaretlenebilir.
Bir alanın veya yerel (local) değişkenin değerinin değişmeyeceğinden emin olduğunuzda const değiştiricisini kullanın.

## Readonly (Salt Okunur)
Readonly bir alan, bildirim sırasında veya aynı sınıfın yapıcısı içinde başlatılabilir. Bu nedenle, readonly alanlar run-time (çalışma zamanı) sabitleri için kullanılabilir. Readonly bir alan, bu alana atanmanın yalnızca sınıfın bildiriminin bir parçası olarak veya bir kurucuda gerçekleşebileceği alandır.
~~~csharp
class BenimSinifim
{
   readonly int X = 10; // beyan edildiği sırada değeri atanan sabit
   readonly int X1;

   public BenimSinifim(int x1)
   {
      X1 = x1; // çalışma zamanında değeri atanır
   }
}

~~~
Başka bir örnek;

~~~csharp
public class TestClass
{
   public readonly string ConnectionString = "TestConnection";

   public TestClass()
   {
      ConnectionString = "DifferentConnection";
   }

   public void TestMethod ()
   {
      ConnectionString = "NewConnection"; //Derlenmeyecektir
   }
}
~~~

Bu, readonly (salt okunur) bir değişkenin aynı sınıftaki farklı kurucular için farklı değerlere sahip olabileceği anlamına gelir.

Açıkça (explicitly), readonly alanını static olarak belirleyebilirsiniz çünkü readonly alanlar const gibi varsayılan olarak static değildir.

ReadOnly anahtar kelimesi, değer (value) türüne ve referans (reference) türüne uygulanabilir.
Çalışma zamanında (run time) bir alanı sabitlemek istediğinizde readonly değiştiriciyi kullanın.
Sonuç olarak; Const compile time sabitidir, ReadOnly run time sabitidir.

Diagram-Readonly-Vs-Constant

## Static
Static anahtar kelimesi, spesifik bir üyeyi static olarak belirtmek için kullanılır; bu, static üyelerin tüm nesneler için ortak olduğu ve belirli bir nesneye bağlanmadıkları anlamına gelir. Bu anahtar kelime sınıflar (class), alanlar (fields), yöntemler (methods), özellikler (properties), operatörler (operators), olaylar (events) ve yapıcılar (constructors) ile kullanılabilir, ancak dizin oluşturucular (indexers), yıkıcılar (destructors) veya sınıf dışındaki türlerle kullanılamaz.
~~~csharp
class BenimSinifim
{
   static int X = 10;
   int Y = 20;
   public static void Goster()
   {
      Console.WriteLine(X);
      Console.WriteLine(Y); //Yalnızca statik üyelere erişebileceğinizden bu erişim hatalıdır
   }
}
~~~
Statik anahtar kelimesi ile ilgili önemli noktalar:

- Static anahtar sözcüğü bir sınıfa uygulanırsa, sınıfın tüm üyeleri static olmalıdır.
- Static yöntemler (methods) yalnızca aynı sınıfın static üyelerine erişebilir. Static özellikler (properties), bir sınıfın static alanlarının değerini almak veya ayarlamak için kullanılır.
- Static bir kurucu method (constructor) parametreleştirilemez. Erişim düzenleyicileri Static yapıcıya (static constructor) uygulanamaz, her zaman sınıfın static alanlarını başlatmak için kullanılan genel bir varsayılan yapıcıdır.
Özetle;
