# Вычислить число c заданной точностью d
# Пример:
# - при d = 0.001, π = 3.141
# Ввод: 0.01
#     Вывод: 3.14
#     Ввод: 0.001
#     Вывод: 3.141
import math
accuracy = float(input("Введите требуемую точность округления числа Пи: "))
if accuracy >= 0.1:
    print("Введено ошибочное значение, пожалуйста повторите ввод!")
num = int(len(str(accuracy).split('.')[1]))
print("Округленное число= ",round(math.pi, num))
