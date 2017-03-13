while True:
    num = int(input("Escolha umas das duas opcoes abaixo!\n[1] Metro para Centimetro\n[2] Centimetro para Metro\n[3] Sair\n"))
    if num == 1:
        met = input("\nDigite o metro\n")
        result = float(met) * 100
        print("\nA resposta e >> " + str(result) + " centimetros\n\n")
    elif num == 2:
        cen = input("\nDigite o centimetro\n")
        result = float(cen) / 100
        print("\nA resposta e >> " + str(result) + " metros\n\n")   
    elif num == 3: 
        print("\nEspero ter sido util (:\n\n")
        break
    else:
        print("\nOpcao invalida\n\n")
        
#http://pt.stackoverflow.com/q/189716/101
