#include <iostream>
using namespace std;

void Payload(unsigned long lastTime, float deltaOne, float deltaTwo, int factor) {
	char buffer[sizeof(unsigned long) + sizeof(float) + sizeof(float) + sizeof(int) + 13];
    sprintf(buffer, "CAPTION,%u,%.4f,%.4f,%d,", lastTime, deltaOne, deltaTwo, factor);
    printf("%s", buffer);
    printf("\nCAPTION,11285600,50.2035,54.2035,5,\n");
}

int main() {
    unsigned long record = 11285600UL;
    float delta1 = 50.2035;
    float delta2 = 54.2035;
    int factor = 5;
    Payload(record, delta1, delta2, factor);
}

//http://pt.stackoverflow.com/q/184523/101
