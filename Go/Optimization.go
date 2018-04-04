package main
import "fmt"

func main(){
	x := uint32(64)
	fmt.Print(uint64(1 << 65 - 1 << x - 1))
}

//https://pt.stackoverflow.com/q/288646/101
