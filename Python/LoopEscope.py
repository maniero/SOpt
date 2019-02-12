import random

def main():
    ponto = 0
    letra = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']
    while True:    
        rletra = letra[random.randint(0, 25)]
        print (rletra)
        print ('Sua pontuação é:', ponto)
        if input('') == rletra:
            ponto += 1
            print ('Sua pontuação é:', ponto)
        else:
            print('errado')
            break
main()

#https://pt.stackoverflow.com/q/361805/101
