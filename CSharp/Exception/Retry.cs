var tentou = 0;
while (tentou < 3) {
    try {
        //faz algo aqui que pode lançar a exceção que está capturando
        break;
    } catch (SuaExeption ex) {
        tentou++;
        //se quiser faça algo mais
    }
}

//https://pt.stackoverflow.com/q/581623/101
