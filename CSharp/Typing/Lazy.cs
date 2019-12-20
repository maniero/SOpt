public sealed class Singleton {
    private static readonly Lazy<Singleton> instanceHolder = new Lazy<Singleton>(() => new Singleton());
    private Singleton() { ... }
    public static Singleton Instance => instanceHolder.Value;
}

//E sem:

private static object lockingObject = new object();
public static LazySample InstanceCreation() {
    if (lazilyInitObject == null) {
        lock (lockingObject) {
            if (lazilyInitObject == null) lazilyInitObject = new LazySample();
        }
    }
    return lazilyInitObject;
}

//https://pt.stackoverflow.com/q/427611/101
