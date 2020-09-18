using var response = req.GetResponse()) ;
var location = response.Headers["Location"];
using var srResponseReader = new StreamReader(response.GetResponseStream()));
html = srResponseReader.ReadToEnd();

//https://pt.stackoverflow.com/q/52093/101
