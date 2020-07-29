template<class T> struct dependent_false : std::false_type {};
template<class T>
T soma(const T& x, const T& y) {
    if constexpr (std::is_arithmetic_v<T>)
        return x + y;
    else
        // faz alguma coisa aqui
        static_assert(dependent_false<T>::value, "Must be arithmetic");
}

//https://pt.stackoverflow.com/q/321359/101
