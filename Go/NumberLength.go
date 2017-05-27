package main
import ("fmt"
        "strconv"
        "math")

func main() {
	t := strconv.Itoa(57890)
    fmt.Println("Tamanho:", len(t))
    fmt.Printf("Terceiro caracteres: %c\n", t[2])
    fmt.Println("Tamanho matematicamente calculado:", math.Floor(math.Log10(math.Abs((57890)))) + 1)
}

//https://pt.stackoverflow.com/q/208028/101
