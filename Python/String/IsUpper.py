def contaMaiuscula(string):
    mai = 0
    min = 0
    for c in string:
        if c.isupper():
            mai += 1
        else:
            min += 1
    return mai, min
    
#https://pt.stackoverflow.com/q/411680/101
