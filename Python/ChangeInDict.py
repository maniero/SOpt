dic = {}
n = int(input()) 
for i in range(n):
    palavra, adjetivo = input().split()
    dic[palavra] = adjetivo
frase = input().split()
for palavra in frase:
    if palavra in dic:
        print(dic[palavra])

#https://pt.stackoverflow.com/q/346650/101
