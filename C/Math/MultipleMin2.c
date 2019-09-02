int main(void) {
    float a, b, c, d;
    scanf("%f\n%f\n%f\n%f\n", &a, &b, &c, &d);
    printf("%f", (a + b + c + d - fmin(a, fmin(b, fmin(c, d)))) / 3);
}

//https://pt.stackoverflow.com/q/57242/101
