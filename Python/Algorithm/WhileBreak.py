def entrada(lista):
    while True:
        ad = (int(input('Digite um valor: ')))
        if ad not in lista:
            lista.append(ad)
            print('Adicionado com sucesso!')
        else:
            print('Valor duplicado. Adição negada.')
        while True:
            ask = str(input('Deseja continuar?[S/N] ')).strip().upper()[0]
            if ask == 'S':
                break
            elif ask == 'N':
                return
lista = []
entrada(lista)
print(lista)

#https://pt.stackoverflow.com/q/352398/101
