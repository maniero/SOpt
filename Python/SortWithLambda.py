def sorting(list, key):
    for i in range(len(list)):
        for j in range(i, len(list)):
            if key(list[i]) > key(list[j]):
                list[i], list[j] = list[j], list[i]
def size(int_type):
   length = 0
   count = 0
   while (int_type):
       count += (int_type & 1)
       length += 1
       int_type >>= 1
   return count
arr = [5,4,3,1,6,8,10,9]
sorting(arr, lambda x : size(x))
print(arr)

#https://pt.stackoverflow.com/q/347634/101
