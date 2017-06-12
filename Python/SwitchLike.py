x = 1
if x == 0:
    print("imprime 0")
elif x == 1:
    print("imprime 1")
elif x == 2:
    print("imprime 2")
else:
   print("imprime outra coisa")

print({
        1 : "deu um",
        2 : "deu dois",
    }[x])

print({
	    1 : lambda x: x + 2,
        2 : lambda x: x - 2,
        3 : lambda x: x * 2
}[x](5))

#https://pt.stackoverflow.com/q/211841/101
