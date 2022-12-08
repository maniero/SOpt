{
    var memoryStream = new MemoryStream();
    try {
        //código    
    } finally {
        if (memoryStream != null) {
            memoryStream.Dispose();
        }
    }
}
using var memoryStream = new MemoryStream();

using MemoryStream memoryStream = new();

//https://pt.stackoverflow.com/q/66230/101
