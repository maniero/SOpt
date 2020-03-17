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
if ($pessoa instanceof Model) echo "implementa Model";
if ($pessoa instanceof Cloneable) echo "implementa Cloneable";

//https://pt.stackoverflow.com/q/160384/101
