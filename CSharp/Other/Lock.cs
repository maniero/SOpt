lock (instances) {
    if (!instances.ContainsKey(key)) {
        // ... create connection
        instances.Add(key, /* add connection */);
    }
    return instances[key];

lock (lockObject) {
    DoSomething();
}

object obj = (System.Object)lockObject;
System.Threading.Monitor.Enter(obj);
try {
    DoSomething();
} finally {
    System.Threading.Monitor.Exit(obj);
}

//https://pt.stackoverflow.com/q/147519/101
