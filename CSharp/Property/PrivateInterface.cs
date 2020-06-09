public interface IBar {
    string Id { get; }
}

class Foo : IBar {
    public string Name { get; private set; }
}

//https://pt.stackoverflow.com/q/230781/101
