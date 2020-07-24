def nomes(x):
    nome = []
    for i in x:
        if len(i) == 4:
            nome.append(i)
    return nome
    
print(nomes(["abc", "jose", "ana", "maria", "joao", "abcd"]))

#https://pt.stackoverflow.com/q/314030/101
