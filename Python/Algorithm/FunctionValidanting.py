def pedeChute():
    while True:
        try:
            chute = int(input("chute: "))
            if chute == 0:
                return chute
        except:
       	    pass

def jogo():
    while True:
        #algo aqui
        chute = pedeChute() #sempre será válido
        #algo aqui
        
#https://pt.stackoverflow.com/q/449742/101
