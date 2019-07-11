def filtro(lista, predicado, acao):
    for item in lista:
        if predicado(item):
            acao(item)

funcao = lambda x: filtro(x, lambda y: y > 0, lambda z: print(z))

funcao([10, -20, 30])

#https://pt.stackoverflow.com/q/50422/101
