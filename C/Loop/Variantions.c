while (num < n1) {
    printf ("%d ", vet[num]);
    num++;
}
num = 0;
while (num < n1) {
    if (vet[num] == 0) {
        vet[num] = x1;
    }
   num++;
}

for (int num = 0; num < n1; num++) {
    printf ("%d ", vet[num]);
}
for (int num = 0; num < n1; num++) {
    if (vet[num] == 0) {
        vet[num] = x1;
    }
}

for (int num = 0; num < n1; num++) {
    printf ("%d ", vet[num]);
    if (vet[num] == 0) {
        vet[num] = x1;
    }
}

//https://pt.stackoverflow.com/q/55348/101
