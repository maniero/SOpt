public bool isIpPrivate (IPAddress ipAddress) {
    var ipAddressParts = ipAddress.ToString().Split(new String[] { "." });
    var ipAddressParsed = new int[] { int.Parse(ipAddressParts[0]),
        int.Parse(ipAddressParts[1]),  int.Parse(ipAddressParts[2]),
        int.Parse(ipAddressParts[3]) };
    return ipAddressParsed [0] == 10 ||
        (ipAddressParsed [0] == 192 && ipAddressParsed [1] == 168) ||
        (ipAddressParsed [0] == 172 && (ipAddressParsed [1] >= 16 &&
        ipAddressParsed [1] <= 31));
}

//https://pt.stackoverflow.com/q/81565/101
