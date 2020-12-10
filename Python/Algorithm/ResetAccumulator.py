def add_divisors(list_num):
    final_list = []
    for number in list_num:
        divisors = []
        for x in range(1, number + 1):
            if number % x == 0:
                divisors.append(x)
        final_list.append(divisors)
    return final_list

print(add_divisors([3, 4, 6]))

#https://pt.stackoverflow.com/q/485903/101
