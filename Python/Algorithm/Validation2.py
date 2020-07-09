def filtro(p):
    if p > 6:
        return True
    return False

x = int(input("Valor de x"))
if filtro(x): print(x)
x = int(input("Valor de x"))
if filtro(x): x = x * 2
print(x)
x = int(input("Valor de x"))
if filtro(x): x = x * 2
print(x)

#https://pt.stackoverflow.com/q/274003/101
