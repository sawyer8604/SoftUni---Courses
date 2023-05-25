function solve(number, arr){

    let newArr = [];

    for (let index = 0; index < number; index++) {
        newArr.unshift(arr[index]);        
    }
    console.log(newArr.join(' '));
}

solve(3, [10, 20, 30, 40, 50]);
solve(4, [-1, 20, 99, 5]);
solve(2, [66, 43, 75, 89, 47]);
