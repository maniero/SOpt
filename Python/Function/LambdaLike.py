def funcao1():
    return 1
def funcao2():
    return 2

dicionario_funcoes = { 1: funcao1, 2: funcao2 }
escolha = int(input('Escolha uma opcao: '))
print(dicionario_funcoes[escolha]())

#https://pt.stackoverflow.com/q/515548/101
