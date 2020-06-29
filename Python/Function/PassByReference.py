def value(x):
    x = 1
def ref(x):
    x[0] = 1
x = 0
value(x)
print(x)
x = [0]
ref(x)
print(x[0])

#https://pt.stackoverflow.com/q/255451/101
