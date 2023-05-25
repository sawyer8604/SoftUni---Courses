function solve(firstNum, secondNum, thirdNum){
    let largestNum ;

    if(firstNum > secondNum){
        largestNum = firstNum;
    }
    else{
        largestNum = secondNum;
    }

    if(largestNum < thirdNum)
    {
        largestNum = thirdNum;
    }

    console.log(`The largest number is ${largestNum}.`);
}

solve(5, -3, 16);
solve(-3, -5, -22.5);
solve(1, 1, 1);