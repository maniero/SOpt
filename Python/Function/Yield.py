def ler_dados():
    with open('CTE_ARBA.txt', 'r') as arq:
        dados = arq.readlines()
        for linha in dados:
            yield linha

for linha in ler_dados():
    print(linha)
    
#https://pt.stackoverflow.com/q/533379/101
