class Account {
    private lock myLock //isto pode ser escondido do código
    private int balance := 0
    invariant balance >= 0

    public method boolean withdraw(int amount)
        precondition amount >= 0 {
        myLock.acquire() //isto pode ser simplificado no código
        try {
            if balance < amount {
                return false
            } else {
                balance := balance - amount
                return true
            }
        } finally {
            myLock.release()
        }
    }

    public method deposit(int amount)
        precondition amount >= 0 {
        myLock.acquire() //isto pode ser simplificado no código
        try {
            balance := balance + amount
        } finally {
            myLock.release()
        }
    }
}

//https://pt.stackoverflow.com/q/208859/101
