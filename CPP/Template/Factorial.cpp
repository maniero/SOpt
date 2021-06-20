template <int N>
struct factorial {
  enum { value = N * factorial<N - 1>::value };
};

template <>
struct factorial<0> {
  enum { value = 1 };
};

enum { result = factorial<5>::value }; // 5 * 4 * 3 * 2 * 1 == 120

//https://pt.stackoverflow.com/q/150181/101
