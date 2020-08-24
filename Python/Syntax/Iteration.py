tmp_iter = frase.__iter__()
while True:
    try:
        letra = tmp_iter.__next__()
        print(letra, end = "")
        sleep(0.5)
    except StopIteration:
        break
        
#https://pt.stackoverflow.com/q/357246/101
