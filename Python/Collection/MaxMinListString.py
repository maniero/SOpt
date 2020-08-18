a = 'joao 1 0 10 2 3'
b = a.split()
c = []
for i in b:
    try:
        c.append(int(i))
    except ValueError:
        pass
print(max(c))
print(min(c))

#https://pt.stackoverflow.com/q/346896/101
