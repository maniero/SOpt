def letras():
    yield 'A'
    yield 'B'
    yield 'C'
gerador = letras()
print(next(gerador))
print(next(gerador))
print(next(gerador))
print(next(letras()))
print(next(letras()))

#https://pt.stackoverflow.com/q/365978/101
