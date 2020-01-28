IPAddress gateway = GetDefaultGateway();
if (gateway != null) {
    label8.Text = string.Join(".", gateway.GetAddressBytes().Select(x => x.ToString()));
}

//https://pt.stackoverflow.com/q/136873/101
