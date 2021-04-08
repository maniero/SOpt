def somentenumeros(entrada):
    try:
        int(entrada)
        return True
    except:
        return False

while True:
    cpf = input('Digite seu CPF ou digite os nove primeiros digitos ')
    if not somentenumeros(cpf) or (len(cpf)!= 9 and len(cpf) != 11):
        print('Erro. O valor digitado era inválido.')
    else:
        break
print(cpf)

#http://pt.stackoverflow.com/q/187869/101
