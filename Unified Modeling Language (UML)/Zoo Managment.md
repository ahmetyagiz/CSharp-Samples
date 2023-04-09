## Zoo Managment System

## Problem
Bir hayvanat bahçesindeki hayvanlar hakkındaki bilgileri takip etmek için bir sistem tasarlıyorsunuz.

- Hayvanlar:
- Atlar (atlar, zebralar, eşekler vb.),
- Kedigiller (kaplanlar, aslanlar vb.),
- Kemirgenler (sıçanlar, kunduzlar vb.) gibi gruplardaki türlerle karakterize edilir.
- Hayvanlar hakkında depolanan bilgilerin çoğu tüm gruplamalar için aynıdır.
- tür adı, ağırlığı, yaşı vb.
- Sistem ayrıca her hayvan için belirli ilaçların dozajını alabilmeli => getDosage ()
- Sistem Yem verme zamanlarını hesaplayabilmelidir => getFeedSchedule ()

Sistemin bu işlevleri yerine getirme mantığı, her gruplama için farklı olacaktır. Örneğin, atlar için yem verme algoritması farklı olup, kaplanlar için farklı olacaktır.

Polimorfizm modelini kullanarak, yukarıda açıklanan durumu ele almak için bir sınıf diyagramı tasarlayın.

## Çözüm

https://lucid.app/lucidchart/e4b43934-4069-4c5d-8366-2d54eab542ce/edit?viewport_loc=-641%2C-218%2C2371%2C1419%2C0_0&invitationId=inv_cb3fab48-7204-42f0-b71e-5e6919d0f27b

![Zoo Managment System (1)](https://user-images.githubusercontent.com/78081616/230768634-a76afef4-578b-4b9e-b821-ef036680d0ce.png)
