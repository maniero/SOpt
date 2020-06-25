def GeraCondicao(valor):
    def Condicao(item):
        return item > valor
    return Condicao

condicao = GeraCondicao(5)
for i in range(0, 10):
    if condicao(i)
        print i
        
#https://pt.stackoverflow.com/q/252596/101
