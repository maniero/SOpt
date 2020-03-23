@{
foreach (var item in Model) {
    var total = item.quantity * item.product.price;
    ...
    @Html.DisplayFor(modelItem => total)
}

//https://pt.stackoverflow.com/q/440965/101
