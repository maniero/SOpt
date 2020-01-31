typedef union {
    struct {
        int8_t a;
        int8_t b;
        int8_t c;
        int8_t d;
    };
    int32_t x;
} meu_tipo;

meu_tipo var;
var.a = 0xFF;
var.b = 0xC0; 
var.c = 0xA5;
var.d = 0x0F;
int32_t y = var.x;

//https://pt.stackoverflow.com/q/137393/101
