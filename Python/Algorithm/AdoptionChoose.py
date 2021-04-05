def adocao():
    p1 = int(input("Digite a sua idade: "))
    p2 = int(input("Digite a idade do adotando: "))
    p3 = input("Você é irmão ou ascendente do adotando? [S/N]: ")
    p4 = input("É adoção conjunta? [S/N]: ")
    p5 = input("Os pais do adotando é desconhecido ou ele foi destituído do poder familiar? [S/N]: ")
    if p1 < 18 or p1 - p2 < 16 or p3 == "S":
        print("Você não pode adotar!!")
        return
    if p4 == "S":
        p6 = input("Vocês são casados ou possui união estável? [S/N]: ")
        if p6 == "N":
            print("Você não pode adotar!!")
            return
    if p5 == "N":
        p7 = input("Os pais do adotando conscentiu a adoção? [S/N]: ")
        if p7 == "N":
            print("Você não pode adotar!!")
            return
    if p5 == "S" and p2 >= 12:
        p8 = input("O adotando conscentiu essa adoção? [S/N]: ")
        if p8 == "N":
            print("Você não pode adotar!!")
            return
    print("PARABÉNS!! VOCÊ PODE ADOTAR.")
    
adocao()

#https://pt.stackoverflow.com/q/503502/101
