if ($email !='fulano@email.com' && $email !='ciclano@email.com') {
    echo 'alerta aqui';
}

if (!in_array($email, array('fulano@email.com', 'ciclano@email.com'))) {
    echo 'alerta aqui';
}

//https://pt.stackoverflow.com/q/121892/101
