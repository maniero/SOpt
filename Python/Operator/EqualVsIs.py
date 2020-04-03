a = [1, 2, 3]
b = a #copia a referência para o objeto
print(b is a) #é o mesmo objeto
print(b == a) #ele possuem o mesmo valor
b = a[:] #copiou o objeto
print(b is a) #são objetos diferentes
print(b == a) #mas os valores são os mesmos
print(1000 is 10**3) #são objetos diferentes
print(1000 == 10**3) #mas o valor é o mesmo
print("a" + "b" + "c" is "abc") #objetos diferentes
print("a" + "b" + "c" == "abc") #valores iguais

#https://pt.stackoverflow.com/q/174041/101
