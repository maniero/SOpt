constexpr int x = 10;
constexpr int y = x + 5;

template <typename T>
auto get_value(T t) {
    if constexpr (is_pointer_v<T>)
        return *t;
    else
        return t;
}

template<int N>
constexpr int fibonacci() {
    if constexpr (N >= 2)
        return fibonacci<N - 1>() + fibonacci<N - 2>();
    else
        return N;
}

constexpr bool is_even(int num) { return num % 2 == 0; }

class Point {
    int x;
    int y;
    public:
        constexpr Point(int x, int y): x(x), y(y) {}
        constexpr int get_x() { return x; }
        constexpr int get_y() { return y; }
};

//https://pt.stackoverflow.com/q/493871/101
