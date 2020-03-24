if isinstance(unicode_or_str, str):
    text = unicode_or_str
    decoded = False
else:
    text = unicode_or_str.decode(encoding)
    decoded = True
    
#https://pt.stackoverflow.com/q/167305/101
