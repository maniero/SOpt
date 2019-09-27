int CentimeterToPixel(double centimeter) {
    double pixel = -1;
    using var g = this.CreateGraphics())
    pixel = centimeter * g.DpiY / 2.54d;
    return (int)pixel;
}

//https://pt.stackoverflow.com/q/83954/101
