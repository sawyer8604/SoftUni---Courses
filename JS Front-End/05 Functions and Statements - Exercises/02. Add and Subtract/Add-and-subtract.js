function addAndSubtract(firstNum, secondNum, thirdNum) {
    
    return subtract(sum(firstNum, secondNum), thirdNum);

    function sum(firstNum, secondNum){
        return firstNum + secondNum;
    }

    function subtract(first, second){
        return first - second;
    }
}

console.log(addAndSubtract(23,
    6,
    10
    ))

console.log(addAndSubtract(1,
    17,
    30    
    ));