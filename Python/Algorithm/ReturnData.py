def computador_escolhe_jogada(n, m):
    if n <= m:
        pecas_comp = n
        n = 0
    else:
        a = 1 
        while a < m:
            resto = n - a
            if resto % (m + 1) == 0:
                n -= a
                pecas_comp = a
                a = m
            else:
                a += 1
    return pecas_comp

def rodadas(n, m):
    while n > 0:
        pecas_comp = computador_escolhe_jogada(n, m)
        print("O computador tirou ", pecas_comp, "peças.")
        print("Agora restam ", n, "peças no tabuleiro.")
    return 1 

def partida():
    n = int(input("Quantas peças?"))
    m = int(input("Limite de peças por jogada?"))
    if n // (m + 1) == 0:
        print("Você começa")
        return 1
    else:
        return 2

rodadas(n, m)

#https://pt.stackoverflow.com/q/361106/101
