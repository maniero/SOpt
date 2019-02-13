def mulipleReplace(text):
    return "".join(["" if char in ".!?," else char for char in text])
print(mulipleReplace("abc.def"))

#https://pt.stackoverflow.com/q/361551/101
