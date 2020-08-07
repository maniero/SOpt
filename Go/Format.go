package main
import "fmt"

func descreve(x, y int) string {
    return fmt.Sprintf("%d + %d = %d", x, y, x + y)
}

func main(){
	fmt.Printf(descreve(1, 2))
}

//https://pt.stackoverflow.com/q/466752/101
