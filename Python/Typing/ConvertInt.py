a = "11001100"
b = "01101100"

def p_and(a,b):
  aux=[]
  for i in range(8):
    aux.append(int(a[i]) and int(b[i]))
  return aux

print (p_and(a,b))

#https://pt.stackoverflow.com/q/421873/101
