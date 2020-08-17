animals = ['Cat', 'Dog', 'Elephant']
for animal in animals:
    print(animal, id(animal))
for animal in animals:
    if len(animal) > 3:
        animal = animal[:3]
    print(animal, len(animal), id(animal))
for animal in animals:
    print(animal, len(animal), id(animal))

#https://pt.stackoverflow.com/q/344754/101
