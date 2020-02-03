<?php
class A {
	public $b;
	
	public function __construct(B $b) {
	    $this->b = $b;
	}
}

class B {}

class C extends A {
	public function __clone() {
		$this->b = clone $this->b;
	}
}

$a = new A(new B);
$aa = clone $a;
$b = $a;
$c = new C(new B);
$cc = clone $c;
echo "CÓPIA\n";
var_dump($a === $b);
var_dump($a->b === $b->b);
echo "SEM __CLONE\n";
var_dump($a === $aa);
var_dump($a->b === $aa->b);
echo "COM __CLONE\n";
var_dump($c === $cc);
var_dump($c->b === $cc->b);

//https://pt.stackoverflow.com/q/138003/101
