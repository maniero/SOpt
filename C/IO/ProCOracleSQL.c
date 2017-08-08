/* ... */
for (;;) {
    printf("Give student id number : ");
    scanf("%d", &id);
    EXEC SQL WHENEVER NOT FOUND GOTO notfound;
    EXEC SQL SELECT studentname INTO :st_name
             FROM   student
             WHERE  studentid = :id;
    printf("Name of student is %s.\n", st_name);
    continue;
notfound:
    printf("No record exists for id %d!\n", id);
}
/* ... */

//https://pt.stackoverflow.com/q/227330/101
