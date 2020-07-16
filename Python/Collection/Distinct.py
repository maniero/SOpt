def remove_dups(L1, L2):
    i = 0
    while i < len(L1):
        if L1[i] in L2:
            L1.remove(L1[i])
        else:
            i += 1

L1 = [1, 2, 3, 4]
L2 = [1, 2, 5, 6]
remove_dups(L1, L2)
print(L1)

#https://pt.stackoverflow.com/q/288232/101
