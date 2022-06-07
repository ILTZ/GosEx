STEP = 0.5

def searchCube(num: float): 
    return (num ** (1./3.))

def qubeTable(botEx, topEx):
    i = float(botEx)
    while (i <= topEx):
        print(f"Для числа {i} кубический корень {searchCube(i)}")
        i += STEP


print("Введите нижнюю границу поиска:")
botEx = int(input())
print("Введите верхнюю границу поиска:")
topEx = int(input())

qubeTable(botEx, topEx)
