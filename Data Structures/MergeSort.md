## Problem
[16,21,11,8,12,22] -> Merge Sort

Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.
Big-O gösterimini yazınız.

## Çözüm
Verilen sayı dizisi [16, 21, 11, 8, 12, 22] için Merge Sort aşamaları şu şekildedir:

İlk olarak, dizi 2 parçaya bölünür:
[16, 21, 11] ve [8, 12, 22]

Her bir alt dizi yine 2 parçaya bölünür:
[16], [21, 11] ve [8], [12, 22]

Alt alt diziler birleştirilerek sıralanır:
[16, 11, 21] ve [8, 12, 22]

2 adet alt dizi oluşur:
[16, 11] ve [21]
[8, 12] ve [22]

2 adet 3 elemanlı alt dizi oluşur:
[11, 16, 21] ve [8, 12, 22]

Tüm dizi sıralanmış olarak birleştirilir:
[8, 11, 12, 16, 21, 22]

Bu şekilde Merge Sort algoritması kullanılarak verilen sayı dizisi sıralanmış oldu.
