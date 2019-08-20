if($time <= time()) {       
     if($time != 0)
         $Server->wsSend(1, 'perfect world');
     foreach ( $Server->wsClients as $id => $client ) 
         $time = time() + $adminMessage['interval'];
}

//Ou para visualizar melhor:

if($time <= time()) {       
     if($time != 0) {
         $Server->wsSend(1, 'perfect world');
     }
     foreach ( $Server->wsClients as $id => $client ) {
         $time = time() + $adminMessage['interval'];
     }
}

//Assim claramente o foreach não está dentro do if. Se a sua intenção era que ele estivesse, a única solução seria:

if($time <= time()) {       
     if($time != 0) {
         $Server->wsSend(1, 'perfect world');
         foreach ( $Server->wsClients as $id => $client ) 
             $time = time() + $adminMessage['interval'];
     }
}

//Eu faria melhor ainda:

if($time <= time()) {       
     if($time != 0) {
         $Server->wsSend(1, 'perfect world');
         foreach ( $Server->wsClients as $id => $client ) {
             $time = time() + $adminMessage['interval'];
         }
     }
}

//https://pt.stackoverflow.com/q/54413/101
