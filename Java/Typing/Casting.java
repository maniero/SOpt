class Animal { 
    public void fazBarulho() {
        System.out.println("silêncio");
    }
}
class Dog extends Animal { 
    public void fazBarulho() {
        System.out.println("au au");
    }
}
class Cat extends Animal { 
    public void fazBarulho() {
        System.out.println("miau");
    }
}
class Main {
    public static void main(String[] args) {
        Dog dog = new Dog();      
        Animal animal = new Animal();
        Animal animal2 = new Dog();
        Animal animal3 = new Cat();
        dog.fazBarulho();
        animal.fazBarulho();
        animal2.fazBarulho(); //concretamente é um cachorro
        animal3.fazBarulho(); //concretamente é um gato
        System.out.println("-- Castings agora --");
        ((Animal)dog).fazBarulho(); //upcasting
        ((Dog)animal2).fazBarulho(); //downcasting, funciona
        ((Dog)animal3).fazBarulho(); //downcasting, dá erro porque um gato não é um cachorro
        ((Dog)animal).fazBarulho(); //downcasting, dá erro aqui
    }
}

//https://pt.stackoverflow.com/q/131091/101
