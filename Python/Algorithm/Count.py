n1 = int(input())
n2 = int(input())
count = 0
for c in range(n1, n2):
    if c % n1 == 0:
        count += 1
print('O numero {} tem {} multiplos menores que {}.'.format(n1, count, n2))

#https://pt.stackoverflow.com/q/449499/101
