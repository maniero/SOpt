<?php
interface Authenticable {
     // métodos
}
interface Model {
    // métodos
}
class Person implements Authenticable, Model {
   // métodos
}
$pessoa = new Person();
print_r(class_implements($pessoa));

//https://pt.stackoverflow.com/q/160384/101
