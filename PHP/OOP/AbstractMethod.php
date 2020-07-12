<?php
abstract class B {
    public function do() {
        $this->hello();
    }
    abstract public function hello();
}


class C extends B {
    public function hello() {
        echo "Hello world!";
    }
}

$B = new C();
echo $B->do();

//https://pt.stackoverflow.com/q/461925/101
