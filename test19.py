def isPalindrome(num):
    num = num**3
    sNum = str(num)
    bC = len(sNum) - 1

    for char in sNum:
        if (char == sNum[bC]):
            bC -= 1
            continue
        else:
            return False

    return True

def func(topEx):
        for j in range(1, topEx):
            if (isPalindrome(j)):
                print(f"Число {j} палиндром в 3 степени")

print("Введите верхнюю границу поиска:")
y = int(input())

func(y)
