const int i = 1;
#define is_bigendian() ( (*(char*)&i) == 0 )

int main(void) {
    int val;
    char *ptr;
    ptr = (char*) &val;
    val = 0x12345678;
    if (is_bigendian()) {
        printf(“%X.%X.%X.%X\n", u.c[0], u.c[1], u.c[2], u.c[3]);
    } else {
        printf(“%X.%X.%X.%X\n", u.c[3], u.c[2], u.c[1], u.c[0]);
    }
    exit(0);
}

//https://pt.stackoverflow.com/q/50457/101
