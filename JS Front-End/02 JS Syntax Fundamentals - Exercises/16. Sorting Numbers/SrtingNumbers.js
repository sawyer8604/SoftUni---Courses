function sortingNumbers(numbers){

    let sortingArr = [...numbers]
    .sort((firstNum, secondNum) =>
    firstNum - secondNum);

    let result = [];

    for (let i = 0; i < numbers.length; i++) {
        if(i % 2 === 0){
            let crrElement = sortingArr.shift();
            result.push(crrElement);
        }else{
            let crrElement = sortingArr.pop();
            result.push(crrElement);
        }
        
    }
    return result;
}

console.log(sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));