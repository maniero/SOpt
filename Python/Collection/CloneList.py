current = [0, 1]
someList = []
while True:
    for n in range(0, 2):
        current[n] += 1
    print(current)
    someList.append(current[:]) #aqui faz uma cópia da lista e usa referêwncia para esta cópia, não a original
    if current == [2, 3]:
        break
print(someList)

#https://pt.stackoverflow.com/q/425908/101
