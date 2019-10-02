def funcao(*parametros):
    for parametro in parametros:
        print(parametro)

def funcao2(**parametros):
    for parametro in parametros:
        print(parametro)

funcao(1, 2, 3, 4, 5)
print()
funcao2(a = 2, b = 3)

#https://pt.stackoverflow.com/q/162956/101
