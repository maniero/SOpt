enum Optional<T> {
    None,
    Some(T)
}

resultado : Optional<i32> = TentaObterResultado();
match resultado {
    Some(valor) => println!("O valor é {}", valor),
    None => println!("Não deu certo")
}

enum Message {
    Quit,
    Move { x: i32, y: i32 },
    Write(String),
    ChangeColor(i32, i32, i32),
}

//https://pt.stackoverflow.com/q/486353/101
