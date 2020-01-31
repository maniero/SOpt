try:
   a = int(input("Escolha entre 1 e 6"))
   if a > 0 and a < 7:
       print ("o valor deve ser entre 1 e 6")
except ValueError:
    print ("Escolha uma opção válida")
    
#https://pt.stackoverflow.com/q/433462/101
