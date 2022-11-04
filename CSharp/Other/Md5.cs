using static System.Text.Encoding;
using System.Security.Cryptography;

using var md5 = MD5.Create();
var hash = md5.ComputeHash(UTF8.GetBytes("dados"));

//https://pt.stackoverflow.com/q/17181/101
