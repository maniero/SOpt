using (var client = new WebClient()) {
    return client.UploadString(url, xml);
}

//https://pt.stackoverflow.com/q/260362/101
