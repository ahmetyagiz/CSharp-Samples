## Problem
[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.

## Çözüm

İlk olarak, listenin ortasındaki eleman olan 3 root olarak seçilir.
Dizimizdeki ilk rakamdan başlayarak root rakamımızdan büyük olanları soluna küçük olanları sağına eklenir.
Her rakam için öncelikle root sayımızdan büyük mü ona bakılır sola veya sağa eklenir.
Root rakamından sonra gelen rakama bakıp büyükse sola küçükse sağa eklenir.

~~~
        3
     /      \
    1        7
   /  \     /  \
  0    2   5    8
          /  \     \
        4    6      9     
~~~
