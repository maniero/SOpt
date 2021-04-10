from itertools import product 

for i in product(*[[1,2,3,4,5,6],[12,15,16,13,-4,2]]): 
    print(i)
for i in product(*[[1,2,3,4,5,6],[12,15,16,13,-4,2],[123,154,165,136,-41,22]]): 
    print(i)

#https://pt.stackoverflow.com/q/360929/101
