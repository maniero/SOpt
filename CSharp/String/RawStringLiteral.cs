using static System.Console;

var name = "world";
WriteLine($"""
    Hello,
    {name}!
""");

WriteLine($@"
    Hello,
    {name}!
");
						 
WriteLine($"""
    "Hello,
    {name}!"
""");
		  
/*						 
WriteLine(@$"
    "Hello,
    {name}!"
");
*/
						 
WriteLine($"""
    ""Hello,
    {name}!""
""");
						 
WriteLine($""""
    """Hello,
    {name}!"""
    \t
"""");
		  
WriteLine($$"""
    Hello,
    {name}!
    Hello,
    {{name}}!
    """);
		  
WriteLine(@$"
    Hello,
    {name}!
    Hello,
    {{name}}!
    ");
		  
/*
WriteLine($""
    Hello,
    {name}!
"");
*/

/*						 
WriteLine(@$"
    "Hello,
    {name}!"
");
*/

//https://pt.stackoverflow.com/q/574344/101
