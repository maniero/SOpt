with open('some_file', 'w') as opened_file:
    opened_file.write('Hola!')

file = open('some_file', 'w')
try:
    file.write('Hola!')
finally:
    file.close()

class File(object):
    def __init__(self, file_name, method):
        self.file_obj = open(file_name, method)
    def __enter__(self):
        return self.file_obj
    def __exit__(self, type, value, traceback):
        self.file_obj.close()

#https://pt.stackoverflow.com/q/535114/101
