function orders(product, quantity) {
    let calculations = {
        'coffee' : quantity * 1.5,
        'water' : quantity * 1,
        'coke' : quantity * 1.4,
        'snacks' : quantity * 2
    }
    let result = calculations[product];
    console.log(result.toFixed(2));
}

orders("water", 5);
orders("coffee", 2);
