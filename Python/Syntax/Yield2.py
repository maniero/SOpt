def impar(elems):
    for i in elems:
        if i % 2:
            yield i

for x in impar(range(1000)):

def numeros():
    yield 1
    yield 2
    yield 3

print numeros()
print numeros()
print numeros()

#https://pt.stackoverflow.com/q/92921/101
