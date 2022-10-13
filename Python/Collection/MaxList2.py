def maximum(lista): 
	max = float('-inf')
	for item in lista:
		try:
			valor = int(item)
			if valor > max:
				max = valor
		except:
			pass
	return max

print(maximum(['4', '07', '08', '2017', '364', '355673087875675']))
print(maximum(['4', '07', '08', '355673087875675', 'a', '2017']))

#https://pt.stackoverflow.com/q/257905/101
