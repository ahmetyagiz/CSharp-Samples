## Problem 1
[22,27,16,2,18,6] -> Insertion Sort

Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.

Big-O gösterimini yazınız.

Time Complexity: Dizi sıralandıktan sonra 18 sayısı aşağıdaki case'lerden hangisinin kapsamına girer? Yazınız

Average case: Aradığımız sayının ortada olması
Worst case: Aradığımız sayının sonda olması
Best case: Aradığımız sayının dizinin en başında olması.

## Çözüm
[22, 27, 16, 2, 18, 6] listesinin Insertion Sort kullanılarak sıralanması aşamaları:

1) 22 ve 27 arasında bir sıralama yapmaya gerek yoktur, çünkü 22 zaten küçük bir listede tek başına sıralıdır.
Liste: [22, 27, 16, 2, 18, 6]

2) 16'yı sıralı bölümden ayırırız ve geri kalan listedeki elemanlarla karşılaştırırız. 16, 22'den küçük olduğundan, 16'yı 22'nin soluna yerleştiririz.
Liste: [16, 22, 27, 2, 18, 6]

3) 2'yi sıralı bölümden ayırırız ve geri kalan listedeki elemanlarla karşılaştırırız. 2, 16'dan daha küçük olduğu için, 2'yi sıralı bölümün en başına yerleştiririz.
Liste: [2, 16, 22, 27, 18, 6]

4) 18'i sıralı bölümden ayırırız ve geri kalan listedeki elemanlarla karşılaştırırız. 18, 22'den küçük olduğu için, 18'i 22'nin soluna yerleştiririz.
Liste: [2, 16, 18, 22, 27, 6]

5) 6'yı sıralı bölümden ayırırız ve geri kalan listedeki elemanlarla karşılaştırırız. 6, 16'dan küçük olduğu için, 6'yı 16'nın soluna yerleştiririz.
Liste: [2, 6, 16, 18, 22, 27]

Big-O gösterimi: O(n^2)

Time Complexity: Worst Case

## Problem 2
[7,3,5,8,2,9,4,15,6] dizisinin Selection Sort'a göre ilk 4 adımını yazınız.
## Çözüm
