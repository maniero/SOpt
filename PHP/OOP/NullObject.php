interface IAnimal {
    public function makeSound();
}

class Dog implements IAnimal {
    public function makeSound() { 
        echo "Woof.."; 
    }
}

class Cat implements IAnimal {
    public function makeSound() { 
        echo "Meowww.."; 
    }
}

class NullAnimal implements IAnimal {
    public function makeSound() { 
        // silence...
    }
}

$animalType = 'elephant';
switch($animalType) {
    case 'dog':
        $animal = new Dog();
        break;
    case 'cat':
        $animal = new Cat();
        break;
    default:
        $animal = new NullAnimal();
        break;
}
$animal->makeSound(); // ..the null animal makes no sound

function Exemplo(IAnimal $animal) {
    $animal->makeSound();
}

//https://pt.stackoverflow.com/q/88741/101
