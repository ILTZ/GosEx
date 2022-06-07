a= []
print ("Введите количество действительных чисел")
n = int(input())
print ("Введите заданное количество чисел")
for i in range(n):
    a.append(int(input()))
print("Заданный список: ", a)
min = 0
max = 0
for i in range (n):
    if a[i]> a[max]:
        max = i
    else:
        if a[i]<a[min]:
            min = i
k = a[max]
a[max] = a[min]
a[min] = k
print ("Максимальное и минимальное значения заменены: ", a)

