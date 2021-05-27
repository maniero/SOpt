def pesquisa_de_surfista(pesquisa):
    dados = {}
    for linha in arquivo:
        (ID, nome, pais, média, prancha, idade) = linha.split(";")
        dados[ID] = (nome, pais, média, prancha, idade)
        print(ID)
        if pesquisa == ID:
            arquivo.close()
return dados

arquivo = open("surfing_data.csv")
id_de_verificação = int(input("Insira a ID do surfista desejado: "))

sufista = pesquisa_de_surfista(id_de_verificação)    
if sufista:
    print("ID:          " + sufer['id'])
    print("Nome:        " + sufer['nome'])
    print("Pais:        " + sufer['pais'])
    print("Média:       " + sufer['média'])
    print("Prancha:     " + sufer['prancha'])
    print("Idade:       " + sufer['idade'])
print(sufista)

//http://pt.stackoverflow.com/q/179406/101
