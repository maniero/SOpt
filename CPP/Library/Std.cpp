#include <cmath>

namespace myLib {
    double sin( double x ){
        return x*( 1 + x*x*( -1./6 + x*x*(1./120) ) ) ;  
    }
}

double sin(double x) {
    return x * (1 + x * x * (-1. / 6 + x * x * (1. / 120 - x * x * (-1. / 5040))));  
}

main() {
    using namespace myLib;
    double sin3std = std::sin(3.0);
    double sin3myLib = myLib::sin(3.0);
    double sin3 = sin(3.0);
}

//https://pt.stackoverflow.com/q/487787/101
