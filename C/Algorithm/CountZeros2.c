#include<stdio.h>
#include<string.h>
#include<stdint.h>

int main() {
    char binario[64];
    memset(binario, '0', 63);
    binario[63] = '\0';
    int64_t decimal;
    scanf("%jd", &decimal);
    int position = 62, count = 0;
    while (decimal > 0) {
        int bit = decimal & 1;
        binario[position--] = '0' + bit;
        count += bit;
        decimal /= 2;
    }
    printf("%s - quantidade de '1' => %d", &binario[position + 1], count);
}

//https://pt.stackoverflow.com/q/152377/101
