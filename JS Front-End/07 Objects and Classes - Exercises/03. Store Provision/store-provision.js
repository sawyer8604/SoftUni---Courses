function solve(stock, products){

    let input = [...stock, ...products];

    let result = {};

    for (let i = 0; i < input.length; i += 2) {
        let crrElement = input[i];
        let nextElement = Number(input[i + 1]);
        if(!result.hasOwnProperty(crrElement)){
            result[crrElement] = 0;
        }
        
        result[crrElement] += nextElement;        
    }

    for (const key in result) {
        console.log(`${key} -> ${result[key]}`);
    }
       
}

solve([
    'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
    ],
    [
    'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    ]
    );