for (int i = 0; i < 2; i++) print(i);

print(0)
print(1)

for (int i = 0; i < 200; i++) print(i);

for (int i = 0; i < user_entry; i++) print(i);

template <class T>
    T max(T a, T b) { return (a > b ? a : b); }
Quando chamar assim:

max(1, 2)

int max(int a, int b) { return (a > b ? a : b); }


void *max(void *a, void *b) { return (*a > *b ? *a : *b); }

*(max(&1, &2))

//https://pt.stackoverflow.com/q/458724/101
