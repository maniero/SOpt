try:
    __enter__()
    open("my_file.txt") as file:
        data = file.read()
        #faça algo com "data"
finally:
    __exit__()
    
#https://pt.stackoverflow.com/q/49238/101
