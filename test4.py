print("Введите стипендию")
A=int(input())
print("Введите расходы")
B = int(input())
Bsum = B
Asum = A
for i in range(8):
    B = B * 1.03
    Bsum = Bsum + B
    Asum = Asum + A
if Bsum <= Asum:
    print ("Просить денег не понадобится")
else:
    print("Сумма, которую придется попросить у родителей: ", round(Bsum-Asum,2))
    
