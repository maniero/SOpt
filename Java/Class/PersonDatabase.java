class Program {
    public static void main(String[] args) {
        PersonDatabase db = new PersonDatabase(3);
        //se quiser aqui colcoa um Scanner para pegar os dados e usá-los no lugar de literais
        db.addPerson("Jorge", "X", 20);
        db.addPerson("João", "Y", 20);
        db.addPerson("Maria", "Z", 20);
        Person pessoa = searchPerson("João", "Y");
        if (pessoa == null) return;
        System.out.println(pessoa.getName() + " | " + pessoa.getSurname());
        pessoa = searchPerson("Jorge", "X");
        if (pessoa == null) return;
        System.out.println(pessoa.getName() + " | " + pessoa.getSurname());
    }
}

class PersonDatabase {
    private static Person[] persons;
    private static int personCount;
    public PersonDatabase(int defaultPersonsCapacity) {
        persons = new Person[defaultPersonsCapacity];
        personCount = 0;
    }
    public void addPerson(String name, String surname, int age) {
        if (personCount == persons.length) {
            System.out.println("Unable to add Person.");
            return;
        }
        persons[personCount] = new Person(name, surname, age);
        personCount++;
        System.out.println("Person added.");
    }
    public int getPersonCount() {
        return personCount;
    }
    public Person searchPerson(String name, String surname) {
        for (Person p : persons) {
            if (p.getName().equals(name) && p.getSurname().equals(surname))
                return p;
        }
        return null;
    }
}

//https://pt.stackoverflow.com/q/351319/101
