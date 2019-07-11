#include <stdio.h>
#include <string.h>

int main(int argc, char* argv[]) {
    FILE* fp;

    /* Our example data structure */
    struct {
        char one[4];
        int  two;
        char three[4];
    } data;

    /* Fill our structure with data */
    strcpy(data.one, "foo");
    data.two = 0x01234567;
    strcpy(data.three, "bar");

    /* Write it to a file */
    fp = fopen("output", "wb");
    if (fp) {
        fwrite(&data, sizeof (data), 1, fp);
        fclose(fp);
    }
}

//https://pt.stackoverflow.com/q/50457/101
