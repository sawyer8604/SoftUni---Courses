function Fruit(fruit, weightInGrams, pricePerKg){

    let needetMoney = (weightInGrams / 1000) * pricePerKg;
    console.log(`I need $${needetMoney.toFixed(2)} to buy ${(weightInGrams/1000).toFixed(2)} kilograms ${fruit}.`)
}

Fruit('orange', 2500, 1.80);