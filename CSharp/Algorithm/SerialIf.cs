var WebReq = HttpWebRequest.Create(GET_Data);
using var WebRes = WebReq.GetResponse);
using var Reader = new StreamReader(WebRes.GetResponseStream);
var Str = Reader.ReadLine;
if (Str.Contains(Answer1)) return "True";
if (Str.Contains(Answer2)) return "Banned";
if (Str.Contains(Answer3)) return "Invalid";
return "Invalid";


//https://pt.stackoverflow.com/q/205022/101
