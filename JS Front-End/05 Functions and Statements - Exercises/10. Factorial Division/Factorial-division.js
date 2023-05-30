function factorialDivision(firstNum, secondNum) {
    
    let firstResult = factorial(firstNum);
    let secondResult = factorial(secondNum);

    console.log((firstResult / secondResult).toFixed(2));

    function factorial(x) { 

        if (x === 0)
        {
            return 1;
        }
            return x * factorial(x-1);
         
    }
}

(factorialDivision(5,
2
));

