import random
m = 1
while m != 0:
    n1 = int(random.random() * 9) + 1
    n2 = int(random.random() * 9) + 1
    m = int(raw_input("{} * {} = ".format(n1, n2)))
    print ("correto!" if m == n1 * n2 else "errado!!")
    
#https://pt.stackoverflow.com/q/259931/101
