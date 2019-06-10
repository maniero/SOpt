print('3 numeros')
data = []
i = 0
while i < 3:
    data.append(input())
    i += 1
numbers = list(map(int, data))
print(numbers)

print('3 numeros')
data = []
for i in range(3):
    data.append(input())

numbers = list(map(int, data))
print(numbers)

#https://pt.stackoverflow.com/q/390006/101
