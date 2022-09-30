#4. Напишите программу, которая принимает на вход 2 числа. Задайте список из N элементов, заполненных числами из промежутка [-N, N].
#  Найдите произведение элементов на указанных позициях(не индексах).
#Position one: 1
#Position two: 3
#Number of elements: 5
#-> [-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5]
#-> 15
number_elements = int(input("Введите количество элементов: "))
first_element = -number_elements
pos_first_element = int(input("Введите позицию первого элемента: "))
pos_second_element = int(input("Введите позицию второго элемента: "))
list = []
for i in range(number_elements * 2 + 1):
    list += [first_element]
    first_element += 1
print(list)
print(f'Произведение заданных элементов {int(list[pos_first_element - 1]) * int(list[pos_second_element - 1])}')