def pedeChute():
    while True:
        try:
            chute = int(input("chute: "))
            return chute
        except:
       	    pass

def jogo():
    while True:
        #algo aqui
        chute = pedeChute() #sempre será válido
        if chute == 0:
        	break
        #algo aqui
        
#https://pt.stackoverflow.com/q/449742/101
