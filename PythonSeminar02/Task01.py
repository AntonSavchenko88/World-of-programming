#1. Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
#in -> out
#- 6782 -> 23
#- 0.67 -> 13
#- 198.45 -> 27

float_num=input('Введите вещественное число - ')
sum = 0
for i in float_num:
    if i != '.':
        sum += int(i)
print('Сумма чисел в введенном вещественом числе = ',sum)