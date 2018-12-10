bool lockWasTaken = false;
var temp = thisLock;
try {
    Monitor.Enter(temp, ref lockWasTaken);
    if (amount > balance) {
        throw new Exception("Insufficient funds");
    }
    balance -= amount;
} finally {
    if (lockWasTaken) {
        Monitor.Exit(temp); 
    }
}

//https://pt.stackoverflow.com/q/28690/101
