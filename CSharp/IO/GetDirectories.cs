try {
    var dirs = new List<string();
    foreach (var dir in Directory.EnumerateDirectories(caminho)) dirs.Add(dir.Substring(dir.LastIndexOf("\\") + 1));
} catch (UnauthorizedAccessException ex) {
    //faça algo útil aqui ou retire esse catch
} catch (PathTooLongException ex) {
    //faça algo útil aqui ou retire esse catch
}
ddlFolders.DataSource = dirs;

//https://pt.stackoverflow.com/q/297152/101
