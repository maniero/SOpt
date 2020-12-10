fn main() {
    let strVar : &'static str = "str";
    let stringVar : String = "String".to_string(); // precisa converter o tipo
    teste(strVar);
    teste(&stringVar);
}

fn teste(texto: &str) {
    println!("Isto é um {}", texto);
}

//https://pt.stackoverflow.com/q/485812/101
