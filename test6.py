print ("Таблица умножения: ")
for i in range (1,10):
    for j in range (1,10):
        print (hex(i), "*", hex(j), "=", hex(i*j))

print ("Таблица сложения: ")
for i in range (1,10):
    for j in range (1,10):
        print (hex(i), "+", hex(j), "=", hex(i+j))    
