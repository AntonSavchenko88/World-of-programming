# Задайте список из N элементов, заполненных числами из промежутка [-N, N].
# Найдите произведение элементов на указанных индексах. Индексы вводятся одной строкой, через пробел.
# n = 3
# [-3, -2, -1, 0, 1, 2, 3]
# --> 0 2 3
# -3 * -1 * 0 = 0
# Вывод: 0
number_elements = int(input("Введите количество элементов в списке: "))
first_element = -number_elements
a,b,c = map(int,input("Введите позиции любых 3-х элементов: ").split())           
list = []
for i in range(number_elements * 2 + 1):
    list += [first_element]
    first_element += 1
print(list)
print(f'Произведение заданных элементов списка= {int(list[a])*int(list[b])*int(list[c])}')