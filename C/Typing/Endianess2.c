const int i = 1;
#define is_bigendian() ( (*(char*)&i) == 0 )

short reverseShort(short s) {
    unsigned char c1, c2;
    if (is_bigendian()) {
        return s;
    } else {
        c1 = s & 255;
        c2 = (s >> 8) & 255;
        return (c1 << 8) + c2;
    }
}

int main (int argc, char* argv[]) {
    printf("%d", reverseShort((short)1234));
}

//https://pt.stackoverflow.com/q/50457/101
