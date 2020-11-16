n = int(input())
i = 0
while i < n:
    try:
        x, y = input().split(" ")
        x = float(x)
        y = float(y)
        if y != 0:
           print(x / y)
           i += 1
        else:
            print('divisao impossivel')
    except ValueError:
       print('fomrmato digitado errado')
       
#https://pt.stackoverflow.com/q/482421/101
