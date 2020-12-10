def gradingStudents(grades):
    n = len(grades)
    for i in range(n):
        if grades[i] < 38:
            grades[i] += 0
        elif grades[i] % 5 == 3:
            grades[i] += 2
        elif grades[i] % 5 == 4:
            grades[i] += 1
    return grades

print(gradingStudents([73, 67, 38, 33]))

#https://pt.stackoverflow.com/q/485898/101
