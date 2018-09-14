#include <stdio.h>
#include <sys\timeb.h> 

int main() { 
    struct timeb start, end;
    int diff;
    int i = 0;
    ftime(&start);

    while(i++ < 999) {
        /*gastando tempo*/
        printf(".");    
    }

    ftime(&end);
    diff = (int) (1000.0 * (end.time - start.time) + (end.millitm - start.millitm));

    printf("\nGastou %u milisegundos\n", diff);
    return 0;
}

//É possível destrinchar o timeb.

void getCurrTimeString(TCHAR* mytime) {
    _timeb myTime;
    struct tm * timeinfo;

    _ftime64_s( &myTime );
    time_t rawtime = myTime.time;
    unsigned short myMillis = myTime.millitm;
    timeinfo = localtime ( &rawtime );
    _stprintf(mytime,_T("%d-%02d-%02dT%02d:%02d:%02d.%03d"),
        (1900+timeinfo->tm_year),
        (timeinfo->tm_mon+1),
        timeinfo->tm_mday,
        timeinfo->tm_hour,
        timeinfo->tm_min,
        timeinfo->tm_sec,
        myMillis);
}

//https://pt.stackoverflow.com/q/39200/101
