a = input()
a = list(a)
print ("исходный список: ", a)
a = [int(i) for i in a]
for i in range(len(a)//2):
    b = a[i]
    a[i] = a[len(a)-i-1]
    a[len(a)-i-1] = b

print("Измененный список: ",a)
