function solve(numbers){

    let evenSum = 0;
    let oddSum = 0;

    for (let index = 0; index < numbers.length; index++) {
        let crrElement = numbers[index];
        if(numbers[index] % 2 === 0){
            evenSum += numbers[index];
        }else{
            oddSum += numbers[index];
        }
                
    }

    let difeerence = evenSum - oddSum;

    console.log(difeerence);
}

solve([1,2,3,4,5,6]);
solve([3,5,7,9]);
solve([2,4,6,8,10]);