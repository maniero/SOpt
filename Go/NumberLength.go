package main
import ("fmt"
        "strconv")

func main() {
	t := strconv.Itoa(57890)
    fmt.Println("Tamanho:", len(t))
    fmt.Printf("Terceiro caracteres: %c", t[2])
}

//https://pt.stackoverflow.com/q/208028/101
