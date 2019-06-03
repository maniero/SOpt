public function addName($name) {
    if (len($name) > $this->getLimitNames()) throw new LimitNameException();
    if ($name == ????) throw new InvalidNameException();
    array_push($this->nameArray, $name);      
}

//https://pt.stackoverflow.com/q/388317/101
