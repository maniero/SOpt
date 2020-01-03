char * txt = malloc(10);
strcpy(txt, "teste maior do que devia"); //aqui já era! Vai ocupar uma memória indevida
strcpy_s(txt, 10, "teste maior do que devia"); //aqui só vai usar "teste mai"

//https://pt.stackoverflow.com/q/126164/101
