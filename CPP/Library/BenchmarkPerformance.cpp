#include <stdio.h>
#include <time.h>
#include <cstdint>

#ifdef WIN32
#include <Windows.h>
#else
#include <sys/time.h>
#include <ctime>
#endif

/* Returns the amount of milliseconds elapsed since the UNIX epoch. Works on both
 * windows and linux. */

uint64_t get_time()
{
#ifdef _WIN32
 /* Windows */
 FILETIME ft;
 LARGE_INTEGER li;

 /* Get the amount of 100 nano seconds intervals elapsed since January 1, 1601 (UTC) and copy it
  * to a LARGE_INTEGER structure. */
 GetSystemTimeAsFileTime(&ft);
 li.LowPart = ft.dwLowDateTime;
 li.HighPart = ft.dwHighDateTime;

 uint64_t ret = li.QuadPart;
 ret -= 116444736000000000LL; /* Convert from file time to UNIX epoch time. */
 ret /= 10000; /* From 100 nano seconds (10^-7) to 1 millisecond (10^-3) intervals */

 return ret;
#else
 /* Linux */
 struct timeval tv;

 gettimeofday(&tv, NULL);

 uint64_t ret = tv.tv_usec;
 /* Convert from micro seconds (10^-6) to milliseconds (10^-3) */
 ret /= 1000;

 /* Adds the seconds (10^0) after converting them to milliseconds (10^-3) */
 ret += (tv.tv_sec * 1000);

 return ret;
#endif
}

int X(int x){
    if(x<=0)
        return 0;
    return(x + X(x-1));
}

int Y(int x){
    int soma=0;
    for(int i=0;i<=x;++i)
        soma+=i;
    return soma;
}

int main(void) {
    uint64_t startTime, endTime, timeElapsed;
    startTime = get_time();
    X(300000);
    endTime = get_time();
    timeElapsed = endTime - startTime;
    printf("Tempo decorrido: %d\n", timeElapsed);
    startTime = get_time();
    Y(300000);
    endTime = get_time();
    timeElapsed = endTime - startTime;
    printf("Tempo decorrido: %d\n", timeElapsed);

    return 0;
}

//https://pt.stackoverflow.com/q/39863/101
