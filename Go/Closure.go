package main

import (
	"fmt"
	"time"
)

type unique struct {
    id, nonce uint64
}

func (unique *unique) print() {
    fmt.Println(unique.id)
}

func main() {
    teste := []unique{unique{1, 2}, unique{3, 4}, unique{5, 6}}
    for _, valor := range teste {
        valorTmp := valor;
        go valorTmp.print()
    }
    time.Sleep(4 * time.Second)
}

//https://pt.stackoverflow.com/q/215263/101
