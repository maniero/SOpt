class Rectangle {
    constructor(height, width) {
        this.name = 'Rectangle';
        this.height = height;
        this.width = width;
    }
    sayName() {
        console.log('Hi, I am a ', this.name + '.');
    }
    get area() {
        return this.height * this.width;
    }
    set area(value) {
        this._area = value;
    }
}

class Square extends Rectangle {
    constructor(length) {
//        super(length, length);
        this.height;
        this.name = 'Square';
    }
}

console.log(new Square(10));

//https://pt.stackoverflow.com/q/448942/101
