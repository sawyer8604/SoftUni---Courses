function solve(input){

    let type = typeof(input);
    let area;

    if(type === 'number'){
        area = (Math.PI *(input**2)).toFixed(2);
        console.log(area);
    }
    else{
        console.log(`We can not calculate the circle area, because we receive a ${typeof(input)}.`)
    }
}

solve(5);
solve('name');