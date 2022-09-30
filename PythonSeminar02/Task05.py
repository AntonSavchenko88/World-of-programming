# ** Реализуйте алгоритм перемешивания списка. Без функции shuffle из модуля random.
#10
#-> [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
#-> [0, 7, 6, 3, 4, 2, 9, 5, 1, 8]
import random
list = list(range(1, 11))
listmixing = []
print(f'Исходный список: {list}')
for i in range(1, 11):
    rnd = random.choice(list)
    listmixing += [rnd]
    list.remove(rnd)
print(f'Перемешанный список:{listmixing}')