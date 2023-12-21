switch (shape) {
    case Square s when s.Side == 0:
    case Circle c when c.Radius == 0:
        return 0;
    case Square s:
        return s.Side * s.Side;
    case Circle c:
        return c.Radius * c.Radius * Math.PI;
    default:
        throw new ArgumentException(message: "shape is not a recognized shape", paramName: nameof(shape));
}

static string Display(object o) => o switch {
    Point { X: 0, Y: 0 }         p => "origin",
    Point { X: var x, Y: var y } p => $"({x}, {y})",
    _                              => "unknown"
};

//https://pt.stackoverflow.com/q/410484/101
