
# s1 = input()
# s2 = input()
# print(s1.count(s2))

# s1 = 'ЯлюблюлюблюлюблюPython'
# s2 = 'люблю'
# i = 0
# cnt = 0
# while i < len(s1) - 1:
#     if s1[i:len(s2) + i] == s2:
#         cnt += 1
#     i += 1
# print(cnt)

# s1 = 'ЯлюблюлюблюлюблюPython'
# s2 = 'лю'
# cnt = 0
# while s2 in s1:
#     s1 = s1.replace(s2, ' ', 1)
#     print(s1)
#     cnt += 1
# print(cnt)

# s1 = 'Я люблю люблюлюблюPython'
# s2 = 'лю'
# res = s1.split(s2)
# print(res)
# print(len(res) - 1)

# # Напишите программу, которая определит позицию второго вхождения строки в списке либо сообщит, что её нет.

# # def find_string(list: list, num):
# #     count = 0
# #     for i in range(len(list)):
# #         if num == list[i]:
# #             count +=1
# #             if count == 2:
# #                 return i
# #     return -1

# # lst = ["qwe", "asd", "zxc", "qwe", "ertqwe"]
# # num = input("Write string: ")

# # print(find_string(lst, num))
# f_path = 'test.txt'

# with open(f_path, 'r') as f_nums:
#     list_nums = f_nums.read().split(' ')
# # print(list_nums)
# for i in range(len(list_nums)):
#     list_nums[i] = int(list_nums[i])

# minmax_list = [min(list_nums), max(list_nums)]

# with open(f_path, 'a') as min_max:
#     min_max.writelines(f"\n {minmax_list} ")
# my_dict = {
#     'key_1': 12,
#     'key_2': 54,
#     'key_3': {
#         'key_4': [1, 2, 3]
#     }
# }

# for key in my_dict:
#     print(key)

# # Печать значений (обьектов)
# for k in dictionary.values():
#     print(k)
# От Svyatoslav Milovidov всем 11:33 AM
#     print(val)
# 'key_3': {
#         '
#     print(dbl)
# my_dict.get('key_100', '?')

# 2. В файле находится N натуральных чисел, записанных через пробел. Среди чисел не хватает одного,
# чтобы выполнялось условие A[i] - 1 = A[i-1]. Найдите это число.
# 1 2 3 4 5 7 8 9

# f_path = 'Task.txt'
# with open(f_path, 'r') as f_nums:
#     list_nums = f_nums.read().split(' ')
# print(list_nums)
# li = set(map(int, list_nums.split()))
# li_1 = set(i for i in range(1, len(li)+1))
# dif = li_1-li
# print(dif)


# 3. Дан список чисел. Создайте список, в который попадают числа,
# описываемые возрастающую последовательность. Порядок элементов менять нельзя.

#     *Пример:*
#     [1, 5, 2, 3, 4, 6, 1, 7] => [1, 5, 6, 7] и т.д.
f = open("C:\The beginning in the world of programming\PithonLesson01\Task.txt", 'r')
sn = f.readline()
f.close()

ls = sn.split()
for i in range(0, len(ls)):
    ls[i] = int(ls[i])

for i in range(1, len(ls)):
    if ls[i] - 1 != ls[i - 1]:
        print(ls[i - 1] + 1)
