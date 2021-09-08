readonly State<int> count = 0;

[Body]
View body() => new StackLayout {
    new Label("Welcome to .NET MAUI!"),
    new Button(
        () => $"You clicked {count} times.",
        () => count.Value ++)
    )
};

//https://pt.stackoverflow.com/q/455179/101
