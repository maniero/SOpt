void swap(int* x, int* y) {
    int tmp = *x;
    *x = *y;
    *y = tmp; //Hardware interrompe e chama a isr()
}
void isr() {
    int x = 1, y = 2;
    swap(&x, &y);
}

//https://pt.stackoverflow.com/q/579164/101
