aa = 0
a = 1
fim = int(input('Digite um termo: '))
for n in range (0, fim):
    s = (aa + a)
    print(s, end = ' → ')
    aa = a
    a = s
print()
s = 0
while s <= fim:
     if s % 2 == 0:
         print(s, end=' → ')
     s = s + 1
     
#https://pt.stackoverflow.com/q/411542/101
