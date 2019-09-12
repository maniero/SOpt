#include <windows.h>
#include <stdio.h>

int main(void) {
    SYSTEM_INFO sysinfo;
    GetSystemInfo(&sysinfo);
    unsigned pageSize = sysinfo.dwPageSize;
    printf("page size: %d\n", pageSize);
    void* target = (void*)0x4e0f68;
    printf("trying to allocate exactly one page containing 0x%p...\n", target);
    void* ptr = VirtualAlloc(target, pageSize, MEM_COMMIT, PAGE_READWRITE);
    if (ptr) printf("got: 0x%p\n", ptr); //   ptr <= target < ptr+pageSize
    else printf("failed! OS wont let us use that address.\n");
}

//https://pt.stackoverflow.com/q/76007/101
