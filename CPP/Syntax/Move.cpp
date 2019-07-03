template <class T>
typename remove_reference<T>::type&&
move(T&& a) {
    return a;
}

//Exemplo de uso:

template <class T> swap(T& a, T& b) {
    T tmp(a); //a passa ter duas referências p/ "a", a original que passou o parâmetro e aqui
    a = b;//e agora duas cópias para "b"
    b = tmp; //mais um cópia para "tmp" que já é cópia para "a"
}

//Veja a diferença:

template <class T> swap(T& a, T& b) {
    T tmp(std::move(a)); //nenhuma cópia é feita em nenhum do casos, só ponteiros se movimentam
    a = std::move(b);   
    b = std::move(tmp);
}

//https://pt.stackoverflow.com/q/49240/101
