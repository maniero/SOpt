int getUserInput (char * returnStr, int maxStringLength) {
   char    *tempStr;
   int     maxLen, totalCount = 0;
   size_t  len;
   maxLen = maxStringLength + 2;     //account for NULL and /newline
   tempStr = malloc(maxLen * sizeof(char));  //temporary holder
   do {
      fgets(tempStr, maxLen, stdin);  // get chars from input buffer
      len = strlen(tempStr);
      if (tempStr[len-1] == '\n') { // newline indicates end of string
         tempStr[len-1] = '\0';   // delete it
         len = strlen(tempStr);   // and recalc length
      }
      totalCount += (int)len;
   }
   while ((int)len > maxStringLength);  // continue to flush extras if too long
   strcpy(returnStr, tempStr);  // copy temp string into output
   free(tempStr);              // and release memory
   return totalCount;   // may be more than the number allowed
}

//https://pt.stackoverflow.com/q/42981/101
