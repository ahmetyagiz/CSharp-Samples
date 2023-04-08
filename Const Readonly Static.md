# "const", "static" ve "readonly"

Kelime | Tanım
------ | ------
const | Bir değişkenin sabit olduğunu ve değiştirilemez olduğunu belirtir. Tanımlama anında bir değer atanır ve bu değer daha sonra değiştirilemez.
static | Bir üyenin tüm nesneler için ortak olduğu ve belirli bir nesneye bağlanmadığı anlamına gelir.
readonly | Bir değişkene tanımlandığı anda veya constructorda sadece bir kez değer atanabileceği anlamına gelir. Değer, sonrasında değiştirilemez.

## Constant (const)
Constant alanlara veya local (yerel) değişkenlere bildirim sırasında bir değer atanmalıdır ve bundan sonra değerleri değiştirilemezler. Varsayılan olarak Constant’lar static’tir, dolayısıyla Constant bir tipi static olarak tanımlayamazsınız.

~~~csharp
public const string ConnectionString = "YourConnectionString";
~~~

Bir const değişkenindeki değer, “compile-time (derleme zamanı)” değeri olarak adlandırılan değerdir ve değişmezdir (program ömrü boyunca değişmez).

## Readonly (Salt Okunur)
Readonly bir alan, tanımlanma sırasında veya aynı sınıfın constructor içinde başlatılabilir. Bu nedenle, readonly alanlar run-time (çalışma zamanı) sabitleri için kullanılabilir.

~~~csharp
class ExampleClass
{
   readonly int num = 10; // beyan edildiği sırada değeri atanan sabit

   public ExampleClass(int num)
   {
      this.num = num; // çalışma zamanında değeri atanır
   }
}
~~~

"const" compile time sabitidir, "readonly" run time sabitidir.

## Static
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
