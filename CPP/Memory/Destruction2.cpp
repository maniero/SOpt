#include <iostream>
#include <memory>
using namespace std;

class Point1 {
public:
    int x;
    int y;

    Point1(int x, int y);
    ~Point1();
};

Point1::Point1(int x1, int y1) {
    x = x1;
    y = y1;
    cout << "criou" << endl; //estou deixando só para fins didáticos
}

Point1::~Point1() {
    cout << "destruiu " << x << " " << y << endl; //para fins de debug
}

unique_ptr<Point1> retorno() {
    unique_ptr<Point1> C(new Point1(1,4));
    return C;
}

int main() {
    auto C = retorno();
    cout << C->x << endl;
    cout << C->y << endl;
}

//https://pt.stackoverflow.com/q/174916/101
