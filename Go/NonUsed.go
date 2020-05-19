import (_ "fmt")

for _ index, item := range retorno.Threads {
    fmt.Fprint(w, item.Id)
}

//https://pt.stackoverflow.com/q/207381/101
