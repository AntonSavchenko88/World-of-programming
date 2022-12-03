# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной идексах.

# Пример:

# [2, 3, 5, 9, 3] -> на нечётных идексах элементы 3 и 9, ответ: 12
import random
list_size = int(input("Введите размерность списка который хотите создать - "))
list = []
for i in range(list_size):
    list.append(random.randint(0,10))
print(list)
sum_elements = 0
for i in range(len(list)):
    if i % 2 == 1:
        sum_elements += list[i]       
print(f"{list} Cумма элементов на нечётных позициях = {sum_elements}")