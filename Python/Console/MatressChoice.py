entrada = input("A B C").split()
A, B, C = int(entrada[0]), int(entrada[1]), int(entrada[2])
if A >= 1 and A <= 300 and B >= 1 and B <= 300 and C >= 1 and C <= 300:
    pass
else:
    raise ValueError("Deu Erro")
entrada = input("Qual a altura e largura").split()
H, L = int(entrada[0]), int(entrada[1])
if H >= 1 and H <= 250 and L >= 1 and L <= 250:
    pass
else:
    raise ValueError("Deu Erro")
if (A and B) > (H and L) or (A and C) > (H and L) or (B and C) > (H and L):
    print ("N")
else:
    print("S")
    
#https://pt.stackoverflow.com/q/454645/101
