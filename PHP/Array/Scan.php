foreach($casa->getTitleIdLocation() as $item) {
    echo $item;
}

function getTitleIdLocation(){
     return $title . " " . $id . " " . $location;
}

//https://pt.stackoverflow.com/q/400473/101
