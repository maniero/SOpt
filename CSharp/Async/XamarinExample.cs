if (!double.TryParse(Area.Text, out var area) || !double.TryParse(Densidade.Text, out var densidade) || !double.TryParse(Custo.Text, out var custo) || !double.TryParse(Volume.Text, out var volume)) {
        await Navigation.PushAsync(new MainPage()); //rever isto
        DisplayAlert("Atenção", @"Todos os campos devem ser preenchidos com valores válidos", "Ok");
    } else {
        var class2 = new Class2();
        class2.Calculo1 = densidade * area * (volume / 1000) * custo;
        await Navigation.PushAsync(new Page1(class2)); //rever isto
    }
}

//https://pt.stackoverflow.com/q/311869/101
