func makeIncrementer(forIncrement amount: Int) -> () -> Int {
    var runningTotal = 0
    func incrementer() -> Int {
        runningTotal += amount
        return runningTotal
    }
    return incrementer
}
let incrementBySeven = makeIncrementer(forIncrement: 7)
print(incrementBySeven())
print(incrementBySeven())

//https://pt.stackoverflow.com/q/453891/101
