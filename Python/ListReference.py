import copy

a = [[2, 3, 5], [1, 3, 5]]
b = copy.deepcopy(a)
b[0][1] = 100
print(a)

#https://pt.stackoverflow.com/q/341040/101
