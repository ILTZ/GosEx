a= []
print ("Введите длину массива:")
n = int(input())
print ("Введите значения:")
for i in range(n):
    a.append(int(input()))
print("Заданный список: ", a)
if len(a) % 2 == 0:
    lenght = len(a)
else:
    lenght = len(a) - 1
for i in range(0,lenght,2):
    k = a[i]
    a[i] = a[i+1]
    a[i+1] = k
print ("Измененный список: ", a)
