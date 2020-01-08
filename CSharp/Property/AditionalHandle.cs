private string _first_name;
public string first_name { 
    get => _first_name;
    set { 
        _first_name = value; 
        handle = getHandle(); 
    }
}
private string _last_name;
public string last_name { 
    get => _last_name;
    set { 
        _last_name = value; 
        handle = getHandle(); 
    }
}

//https://pt.stackoverflow.com/q/126773/101
