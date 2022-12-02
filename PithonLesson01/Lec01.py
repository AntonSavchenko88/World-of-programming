
s1 = input()
s2 = input()
print(s1.count(s2))

s1 = 'ЯлюблюлюблюлюблюPython'
s2 = 'люблю'
i = 0
cnt = 0
while i < len(s1) - 1:
    if s1[i:len(s2) + i] == s2:
        cnt += 1
    i += 1
print(cnt)

s1 = 'ЯлюблюлюблюлюблюPython'
s2 = 'лю'
cnt = 0
while s2 in s1:
    s1 = s1.replace(s2, ' ', 1)
    print(s1)
    cnt += 1
print(cnt)

s1 = 'Я люблю люблюлюблюPython'
s2 = 'лю'
res = s1.split(s2)
print(res)
print(len(res) - 1)

# Напишите программу, которая определит позицию второго вхождения строки в списке либо сообщит, что её нет.

# def find_string(list: list, num):
#     count = 0
#     for i in range(len(list)):
#         if num == list[i]:
#             count +=1
#             if count == 2:
#                 return i
#     return -1
            
# lst = ["qwe", "asd", "zxc", "qwe", "ertqwe"]
# num = input("Write string: ")

# print(find_string(lst, num))
