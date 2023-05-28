function SameNumbers(number){
    
    let numberAsString = number.toString();
    let sum = 0;
    let arr = numberAsString.split('');
    let firstNum = Number(arr[0]);    
    let isSame = true;

    for (const number of numberAsString) {
            sum += Number(number);
            if(firstNum !== Number(number)){
                isSame = false;
            }
    }
    console.log(isSame);
    console.log(sum);
    
}

SameNumbers(2222222);
SameNumbers(1234);