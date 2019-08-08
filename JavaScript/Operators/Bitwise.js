var flags = 5;                       // em binário equivale a 0101
var FLAG_A = 1;                      // 0001
var FLAG_B = 2;                      // 0010
var FLAG_C = 4;                      // 0100
var FLAG_D = 8;                      // 1000
var mask = FLAG_A | FLAG_B | FLAG_D; // 0001 | 0010 | 1000 => 1011
if (flags & FLAG_C) {                // 0101 & 0100 => 0100 => true
   // faz alguma coisa
}
if ((flags & FLAG_B) || (flags & FLAG_C)) {
   // faz alguma coisa
}
var mask = FLAG_B | FLAG_C;          // 0010 | 0100 => 0110
if (flags & mask) {                  // 0101 & 0110 => 0100 => true
   // faz alguma coisa
}
var mask = FLAG_C | FLAG_D;          // 0100 | 1000 => 1100
flags |= mask;                       // 0101 | 1100 => 1101
var mask = ~(FLAG_A | FLAG_C);       // ~0101 => 1010
flags &= mask;                       // 1101 & 1010 => 1000
var mask = ~FLAG_A & ~FLAG_C;
flags &= mask;                       // 1101 & 1010 => 1000
var mask = FLAG_B | FLAG_C;
flags = flags ^ mask;                // 1100 ^ 0110 => 1010

//https://pt.stackoverflow.com/q/52949/101
