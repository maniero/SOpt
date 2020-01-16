#include <string>

template<typename T>
void shuffle(T &array, size_t size) {
    for (int i = 0; i < size; ++i) {
        int index = i % size;
        std::swap(array[i], array[index]);
    }
}
int main() {}

//https://pt.stackoverflow.com/q/131138/101
