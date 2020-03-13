<?php
interface SomeInterface {
    public function someInterfaceFunction();
}

trait SomeTrait {
    function sayHello() {
        echo "Hello my secret is ".static::$secret;
    }
}

abstract class AbstractClass implements SomeInterface {
    use SomeTrait;
}

class TestClass extends AbstractClass {
    static public  $secret = 12345;
    function someInterfaceFunction(){ }
}
$test = new TestClass();
$test->sayHello();

//https://pt.stackoverflow.com/q/157720/101
