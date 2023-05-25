function solve(firstNum, secondnum, operator){
    let result;
 //: '+', '-', '*', '/', '%', '**'.
    switch(operator){

        case '+':
             result = firstNum + secondnum;
        break;
        case '-':
             result = firstNum - secondnum;
        break;
        case '*':
             result = firstNum * secondnum;
        break;
        case '/':
             result = firstNum / secondnum;
        break;
        case '%':
             result = firstNum % secondnum;
        break;
        case '**':
             result = firstNum ** secondnum;
        break;
    }
    console.log(result);
}

solve(5, 6, '+');
solve(3, 5.5, '*');