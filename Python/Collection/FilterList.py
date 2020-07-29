def regras(x):
    if x < 100:
        if x % 2 == 0:
            return x
    else:
        return (x + x)
     
lista = [100, 200, 1000, 3000, 2, 3, 4, 5, 6, 7, 8]
print(list(filter(regras,lista)))

#https://pt.stackoverflow.com/q/321682/101
