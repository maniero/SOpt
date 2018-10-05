function deselectElement(evt){
    if(selectedElement != 0){
        selectedElement.parentNode.removeAttributeNS(null, "onmousemove");
        selectedElement.removeAttributeNS(null, "onmouseup");
        selectedElement = 0;
        dx = evt.clientX;
        //objet 1
        if(selectedLineX == 1){
            circle_x = currentX;
            return circle_x;
        }
    }
    return null; //não me parece coisa boa mas tem que retornar algo, pelo menos assim está explícito    
}

var circle_x = deselectElement(evt);
alert(circle_x);

//https://pt.stackoverflow.com/q/41207/101
