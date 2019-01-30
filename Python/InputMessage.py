l = [1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89]
num = int(input("Choose a number: "))
new_list = []
for i in l:
    if i < num:
        new_list.append(i)
print(new_list)

#https://pt.stackoverflow.com/q/359133/101
