def customLabel(parent, row, column, bold, standard):
    cLabelFrame = Frame(parent)
    cLabelFrame.grid(row=row, column=column)
    Label(cLabelFrame, text=bold, font=('bold').grid(column=0)
    Label(cLabelFrame, text=standard).grid(column=1)
    
#https://pt.stackoverflow.com/q/77178/101
