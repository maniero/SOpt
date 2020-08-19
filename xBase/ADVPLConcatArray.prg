tamanhoAtual = len(aBuffer)
asize(aBuffer, tamanhoAtual + len(aCandidato))
acopy(aCandidato, aBuffer, 1, len(aCandidato), tamanhoAtual + 1)

//https://pt.stackoverflow.com/q/348512/101
