<?php

class A {
    const X = 'A';
    public function x() {
        echo static::X;
    }
}

class B {
    public static $X = 'B';
    public function x() {
        echo self::$X;
    }
    public function x2() {
        echo B::$X;
    }
}

class C extends A {
    const X = 'C';
}

$c = new C();
$c->x();
echo C::X;
echo c::X;
$b = new B();
$b->x();
$b->x2();
echo b::$X;
echo B::$X;

//https://pt.stackoverflow.com/q/242625/101
