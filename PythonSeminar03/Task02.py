# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# Пример:

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]
import random
list_size = int(input("Введите размерность списка который хотите создать - "))
list = []
newlist=[]
for i in range(list_size):
    list.append(random.randint(0, 10))
print(list)
for i in range(len(list)):
    while i < len(list)/2 and list_size > len(list)/2:
        list_size = list_size - 1
        a = list[i] * list[list_size]
        newlist.append(a)
        i += 1
print(f"Произведение пар чисел в списке = {newlist}")