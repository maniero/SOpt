using System;
using Newtonsoft.Json.Linq;

public class Program {
    public static void Main() {
        var text = "{\"SomeResponse\":{\"FIrstAttribute\":8,\"SecondAttribute\":\"On\",\"ThirdAttribute\":{\"Id\":2,\"FirstName\":\"Okkie\",\"Name\":\"Bokkie\",\"Street\":\"\",\"StreetNumber\":null,\"PostCode\":\"\",\"City\":\"\",\"Country\":\"}}}";
        var token = JToken.Parse(text);
        var json = JObject.Parse((string) token);
        Console.WriteLine(json);
    }
}

//https://pt.stackoverflow.com/q/187181/101
