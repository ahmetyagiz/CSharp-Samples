# CSharp-Samples

## Variables

What is a variable?
Variables are our data holders that we use when developing applications.

It is important to choose the right data type depending on the type and size of the data we use. For example, if we only need to keep a single character, it will be sufficient to define your Char data type for that data. It is unnecessary to use a variable of type String. It is important to be able to decide on the right data types for the performance of the application.

Variable definition structure : (Variable Type) (Variable Name) = (Value)

Some points to consider when defining variables are as follows:

-Variables are case sensitive.
-Variable names cannot start with numbers.
-Variable names cannot contain spaces. Only "_" can be used.
-Mathematical expressions, that is, operation operators, cannot be used between variable names.
-Proper names such as class namespace cannot be used.
-Variables must always have a value. Otherwise null must be defined. The compiler throws an error when using unassigned variables.

![datatypes](https://user-images.githubusercontent.com/78081616/188669669-11fa70ec-347e-4abd-8aa7-6c8636643cd7.png)

For the place it occupies in memory: "Width / 8 = Memory Size"

Example: 8 (byte) / 8 = 1

It will occupy 1 byte of computer memory.

## Operators

We use operators when we want to make an assignment or state comparison from within the application. Sometimes the block of code to run needs to change depending on the conditions. This can be achieved by using decision structures and operators together.

According to their functions, operators are categorized as follows.

Assignment and Operational Assignment Operators (=, +=, -=, *=, /=)

Logical Operators (||, &&, !)

Relational Operators (==,!=, <, >, >=,<=)

Arithmetic (+, -, *, /, %, ++, --)

## Type Conversions
When we define a variable, we establish a field from memory depending on the type of that variable. Therefore, assigning a different data type value to this variable that we have defined may cause confusion in the memory.

Most of the time, we may have to work with different data types while writing applications. To get things right in memory, we need to do a type conversion in such cases.

Type conversions can be done in 2 ways:

1 - Implicit Conversion

2 - Explicit Conversion

### 1 - Implicit Conversion
It is the assignment of a variable to a variable with a higher capacity than itself. Since the data type of the target variable will have enough space in memory, there will be no data loss in this conversion. So this conversion can be done by itself.

Sample:

float a; int b = 25; a = b;
Sample:

short x = 10; int y; y = x;
The example above works fine. Because float can store larger numbers than integer and integer can store larger numbers than short data type.

### 2 - Explicit Conversion
In this method, the developer must be doing the conversions. There are different methods for conversion.

### Constructors (TR)
Constructor Kavramı

Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:

Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
Public olarak bildirilmeleri gerekir.
Geri dönüş değerleri yoktur.

Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz. Metotları anlatırken aşırı yüklemeden bahsetmiştik. (Bkz: Metotların Aşırı Yüklenmesi)

Varsayılan Kurucu Metot

Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.

Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.

### C#'ta static Kavramı (TR)

İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir. Metotlar ve alanlar static olarak tanımlanabilir.

Bir Sınıf İçerisinde Bulunan Metotların Static Olarak Tanımlanması

static olma durumunun en bilinen örneği Main() metodudur. Main(), herhangi bir nesne oluşturulmadan önce çağırılması gerektiği için static olarak tanımlanmıştır. Başka bir deyişle de bir nesne metodun üreteceği sonucu etkilemeyecek ise o metot static olarak tanımlanır. Static olarak tanımlanan bir metoda program çalıştığı sürece erişilir, böylece sadece bir metot ile birden çok nesne çağırılır. 

### Framework ne demek?

Framework, yazılım geliştirme sürecini hızlandırmak ve kolaylaştırmak amacıyla hazır bir altyapı ve çerçeve sağlayan bir yazılım aracıdır. Bu altyapı ve çerçeve, yazılım geliştiricilerinin uygulama geliştirirken tekrar tekrar yazmaları gereken temel işlevleri ve kodları içerir.

Framework, uygulama geliştiricilerine birçok avantaj sağlar. Örneğin, daha hızlı ve güvenli kod yazımı, daha az hata ve daha az tekrarlı kod yazımı gibi avantajlar sunar. Ayrıca, framework'ler sık sık güncellenir ve yeni özellikler eklenir, böylece geliştiriciler yazılım geliştirirken son teknolojileri kullanabilirler.

Örneğin, .NET Framework, Windows işletim sistemi üzerinde çalışan uygulamaların geliştirilmesi için kullanılan bir framework'tür. .NET Framework, uygulama geliştiricilerine birçok hazır kütüphane ve bileşen sunarak hızlı bir şekilde uygulama geliştirmelerine yardımcı olur. Bu nedenle, framework'ler yazılım geliştirme sürecinde önemli bir rol oynar ve yazılım geliştiricileri tarafından sıkça kullanılır.
