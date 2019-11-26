int i = 10; // i está valendo 10
byte b = 5; // b está valendo 5
b = (byte)i; // agora b passa valer 10, o cast não o afeta, dentro dentro da capacidade do tipo
b += i; //agora b vale o seu próprio valor mais o de i, então 10 de b e 10 de i = 20
i = b; // agora i passa ter o mesmo valor de b, ou seja, 20.

//https://pt.stackoverflow.com/q/108956/101
