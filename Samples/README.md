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

### 1-Implicit Conversion
### 2-Explicit Conversion

### Implicit Conversion
It is the assignment of a variable to a variable with a higher capacity than itself. Since the data type of the target variable will have enough space in memory, there will be no data loss in this conversion. So this conversion can be done by itself.

Sample:

float a; int b = 25; a = b;
Sample:

short x = 10; int y; y = x;
The example above works fine. Because float can store larger numbers than integer and integer can store larger numbers than short data type.

### Explicit Conversion
In this method, the developer must be doing the conversions. There are different methods for conversion.

### Constructors (TR)
Constructor Kavram??

Bir s??n??ftan bir nesne olu??turuldu??unda biz tan??mlamasak bile arka planda ??al????an varsay??lan yap??c?? metotlara kurucu yada constructor denir. S??n??f nesnesi ilk olu??turuldu??unda yap??lmas??n?? istedi??imiz i??leri kurucu metotlar i??erisinde yapar??z.

Kurucu metot tan??mlarken dikkat edilmesi gereken noktalar ise ??u ??ekildedir:

Yap??c?? metotlar??n isimleri s??n??f isimleri ile ayn?? olmak zorundad??r.
Public olarak bildirilmeleri gerekir.
Geri d??n???? de??erleri yoktur.

Kurucu metotlar??n imzas??n?? de??i??tirerek overload edebiliriz yani a????r?? y??kleyebiliriz. Metotlar?? anlat??rken a????r?? y??klemeden bahsetmi??tik. (Bkz: Metotlar??n A????r?? Y??klenmesi)

Varsay??lan Kurucu Metot

Her s??n??f??n biz tan??mlamasakta bir tane kurucu metotu vard??r. Buna varsay??lan kurucu metot (default constructor) denir.

Default constructor'??n g??revi s??n??f??n i??erindeki ??zelliklere ilk de??er atamas?? yap??lmad??????nda onlar??n default de??erlerini set etmektir. ????yle d??????nebilirsiniz; s??n??f i??erisinde string veri tipinde bir ??zellik varsa ve siz ilk de??er atamas??n?? yapmazsan??z varsay??lan kurucu onun atamas??n?? arka planda null olarak yapar. Ayn?? integer tipinde bir ??zelli??in ilk de??er atamas??n?? 0 olarak yapar.

### C#'ta static Kavram?? (TR)

????inde buludu??u s??n??ftan nesne olu??turulmadan veya hi?? bir nesneye referans olmadan kullan??labilen ??yeler static olarak nitelendirilir. Metotlar ve alanlar static olarak tan??mlanabilir.

Bir S??n??f ????erisinde Bulunan Metotlar??n Static Olarak Tan??mlanmas??

## static olma durumunun en bilinen ??rne??i Main() metodudur. Main(), herhangi bir nesne olu??turulmadan ??nce ??a????r??lmas?? gerekti??i i??in static olarak tan??mlanm????t??r. Ba??ka bir deyi??le de bir nesne metodun ??retece??i sonucu etkilemeyecek ise o metot static olarak tan??mlan??r. Static olarak tan??mlanan bir metoda program ??al????t?????? s??rece eri??ilir, b??ylece sadece bir metot ile birden ??ok nesne ??a????r??l??r. 
