package main
import ("fmt"
        "strconv"
        "math")

func main() {
	t := strconv.Itoa(57890)
    fmt.Println("Tamanho matematicamente calculado:", math.Floor(math.Log10(math.Abs((57890)))) + 1)
    for i := 0; i < len(t); i++ {
        fmt.Printf("%c\n", t[i])
	}
}

//https://pt.stackoverflow.com/q/208028/101
