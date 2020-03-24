size_t strlen (char *str) {
    size_t len = 0;
    while (*str != '\0') {
        str++;
        len++;
    }
    return len;
}

for (int i = 0; i < strlen(string); i++) if (string[i] == ' ') count++;

size_t size = strlen(string);
for (int i = 0; i < size; i++) if (string[i] == ' ') count++;

while (*string != '\0') if (*string++ == ' ') count++;

//https://pt.stackoverflow.com/q/167528/101
