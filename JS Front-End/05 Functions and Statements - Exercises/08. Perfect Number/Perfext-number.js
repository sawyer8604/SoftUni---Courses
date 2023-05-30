function perfectNumber(number) {
    let sum = 0;

    for (let i = 0; i <= number / 2; i++) {
        if(number % i === 0){
            sum += i;
        }
    }

    return number === sum? 'We have a perfect number!' : "It's not so perfect.";
}

console.log(perfectNumber(6));
console.log(perfectNumber(1236498));
console.log(perfectNumber(28));

