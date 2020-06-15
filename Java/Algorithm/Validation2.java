public void decrement_item(View view) {
    if (quantity_item > 0) {
        quantity_item--;
        display_item(quantity_item);
    }
}
Também poderia fazer algo assim para informar melhor:

public void decrementItem(View view) {
    if (quantityItem > 0) {
        quantityItem--;
        displayItem(quantityItem);
    } else {
        messagemErro("Não pode ficar com valor inferior a zero");
    }
}

//https://pt.stackoverflow.com/q/237167/101
