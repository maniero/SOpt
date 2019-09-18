<?php

function bin2si($bin, $bits = 32) { 
    if (strlen($bin) == $bits) { 
        if (substr($bin,0,1) == 0) { // positive or zero 
            $si = base_convert($bin,2,10); 
        } else { // negative 
            $si = base_convert($bin,2,10); 
            $si = -(pow(2,$bits)-$si); 
        } 
        return $si; 
    } 
} 

echo bin2si('11111101', 8);

//https://pt.stackoverflow.com/q/78335/101
