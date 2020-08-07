try {
    obj.TryGetValue(prop.Name, out temp);
    prop.SetValue(usuario, Convert.ChangeType(temp, prop.GetType()));
}
catch (Exception) {
    throw;
}

//https://pt.stackoverflow.com/q/332621/101
