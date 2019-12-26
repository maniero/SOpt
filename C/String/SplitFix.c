char str[9];
char str_line[6][9];
for (int i = 0, b = 0; i < 8; i++) {
   str[i] = '0' + i;
   Serial.println(str);
   if (i == 8) {
       str[8] = '\0';
       memcpy(str_line[b], str, 9);
       i = 0;
       if (++b == 5) break;
   }
}

//https://pt.stackoverflow.com/q/124416/101
