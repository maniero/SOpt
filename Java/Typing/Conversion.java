while (reader.hasNext()) {
    String line = reader.nextLine();
    String[] value = line.split(",");
    Product p = new Product();
    p.setId(value[0]);
    try {
        p.setPrice(value[1]);
    } catch (NumberFormatException e) {
        System.out.println("valor digitado não é válido, tente novamente");
        continue;
    }
    c.addProduct(p);
}

private BigDecimal price;
public void setPrice(String p) {
    this.price = new BigDecimal(p);
}

//https://pt.stackoverflow.com/q/283654/101
