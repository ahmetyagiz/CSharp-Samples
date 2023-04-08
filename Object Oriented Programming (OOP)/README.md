## Object Oriented Programming

Nesne Yönelimli Programlama (Object Oriented Programming), sınıflar ve nesneler kavramına dayanan bir programlama yaklaşımıdır. Bu yaklaşımın amacı, ihtiyaç duyulan programı daha küçük parçalara bölerek, yönetilebilir ve yeniden kullanılabilir hale getirmektir. Her küçük parçanın kendine ait özelliği, verileri ve diğer küçük parçalarla nasıl iletişim kuracağı bilgileri bulunur.

![oop](https://user-images.githubusercontent.com/78081616/230722329-8b5bec82-2b3b-484f-b510-cf0d47186b2b.png)

### 1. Encapsulation:
- Verilerin ve işlevlerin sınıflar içinde saklanması ve sınıf dışından erişimlerin kontrol edilmesi işlemidir.
- Bu prensip, sınıfın kendi içerisindeki yapısının dışarıya kapalı tutulması sayesinde sınıfın daha korunaklı, daha güvenli ve daha sürdürülebilir olmasını sağlar.

### 2. Inheritance:
- Bir sınıfın diğer sınıflardan özelliklerini devralması işlemidir.
- Bu prensip, kodun tekrarını önler, kodun yeniden kullanılabilirliğini arttırır ve nesneler arasında doğru hiyerarşik ilişkiler kurulmasını sağlar.

### 3. Polymorphism:
- Aynı isme sahip işlevlerin farklı şekillerde davranabilmesini sağlayan bir prensiptir.
- Bu prensip, kodun esnekliğini arttırır, aynı işlevi tekrar tekrar yazmaktan kaçınmayı sağlar ve kodun daha okunaklı hale gelmesine yardımcı olur.

### 4. Abstraction:
- Karmaşık yapıların basitleştirilerek, yalnızca gerekli özelliklerin gösterilmesini sağlar. Eğer bir sınıf için nesne üretmek mantıksız geliyorsa o sınıf soyutlanabilir.
- Bu prensip, programcıların nesnelere yalnızca önemli olan özelliklere odaklanmalarını sağlar, kodun daha okunaklı ve daha anlaşılır olmasını sağlar ve kodun yeniden kullanılabilirliğini ve sürdürülebilirliğini arttırır.

Bu dört prensip, nesne yönelimli programlama yaklaşımının temel yapı taşlarını oluşturur ve birlikte kullanıldıklarında, daha esnek, okunaklı, sürdürülebilir ve genişletilebilir kodlar yazmaya yardımcı olurlar.

### Class:
- Class, nesne yönelimli programlamada nesnelerin özelliklerini ve davranışlarını tanımlamak için kullanılan bir şablondur. 

### Object:
- Nesneler sınıftan türetilir. Her nesne, sınıfın özelliklerini ve davranışlarını taşır. Nesne bir sınıfın instance'ıdır.
- C#'ta Car myObj = new Car(); şeklinde kullanılır. Unity'de bunun yerine GameObject kullanılır.

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
| Türetilen sınıflar sınıfın hepsini veya bir kısmını da implement edebilir. | İnterface'i tamamen implement etmek zorundadır. |
