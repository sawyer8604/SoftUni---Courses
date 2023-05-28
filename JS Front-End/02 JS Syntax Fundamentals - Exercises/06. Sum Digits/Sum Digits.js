function SumDigits(number){

    let numberAsString = number.toString();
    let sum = 0;
    
    for (const number of numberAsString) {
        sum += Number(number);
    }
    console.log(sum);
}

SumDigits(245678);
SumDigits(97561);