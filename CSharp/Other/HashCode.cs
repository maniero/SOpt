public override int GetHashCode() {
    unchecked {
        int hash = 17;
        hash *= 23 + field1.GetHashCode(); //cada um tem sua própria fórmula
        hash *= 23 + field2.GetHashCode();
        hash *= 23 + field3.GetHashCode();
        return hash;
    }
}

//https://pt.stackoverflow.com/q/184019/101
