p = i = 0
while (True):
    n = int(input("Digite um número, ou zero para terminar: "))
    if n == 0:
        break;
    else:
        if n % 2 == 0:
            p = p + 1
        else:
            i = i + 1
print ("P = ", p)
print ("I = ", i)

# https://pt.stackoverflow.com/q/434436/101
