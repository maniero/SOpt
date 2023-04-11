#include <inttypes.h>
#include <string.h>

int base64encode(const void* data_buf, size_t dataLength, char* result, size_t resultSize) {
    const char base64chars[] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~_";
    const uint8_t *data = (const uint8_t *)data_buf;
    size_t resultIndex = 0;
    int padCount = dataLength % 3;
    for (size_t x = 0; x < dataLength; x += 3) {
       uint32_t n = ((uint32_t)data[x]) << 16;
       if ((x + 1) < dataLength) n += ((uint32_t)data[x+1]) << 8;
       if ((x + 2) < dataLength) n += data[x+2];
       uint8_t n0 = (uint8_t)(n >> 18) & 63;
       uint8_t n1 = (uint8_t)(n >> 12) & 63;
       uint8_t n2 = (uint8_t)(n >> 6) & 63;
       uint8_t n3 = (uint8_t)n & 63;
       if (resultIndex >= resultSize) return 1;
       result[resultIndex++] = base64chars[n0];
       if (resultIndex >= resultSize) return 1;
       result[resultIndex++] = base64chars[n1];
       if ((x+1) < dataLength) {
           if (resultIndex >= resultSize) return 1;
           result[resultIndex++] = base64chars[n2];
       }
       if ((x+2) < dataLength) {
           if(resultIndex >= resultSize) return 1;
           result[resultIndex++] = base64chars[n3];
       }
    }
    if (padCount > 0) { 
        for (; padCount < 3; padCount++) { 
            if(resultIndex >= resultSize) return 1;
            result[resultIndex++] = '=';
        } 
    }
    if (resultIndex >= resultSize) return 1;
    result[resultIndex] = 0;
    return 0;
}

//https://pt.stackoverflow.com/q/581067/101
