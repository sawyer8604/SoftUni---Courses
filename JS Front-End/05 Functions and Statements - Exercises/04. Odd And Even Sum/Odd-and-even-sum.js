function oddAndEvenSum(number) {

    let numbAsString = number.toString();
    let numbers = [...numbAsString];

    let odd = [...numbers].filter((num) => num % 2 !== 0);
    let even = [...numbers].filter((num) => num % 2 === 0);

    let oddSum = sum(odd);
    let evenSum = sum(even);
    
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);

    function sum(arr){
       let sum = 0;

       for (const num of arr) {
            sum += Number(num);
       }

       return sum;
    }
}

oddAndEvenSum(1000435);