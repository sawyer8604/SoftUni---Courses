function validChecker(x1, y1, x2, y2) {
    // first check
    let firstResult = Math.sqrt(x1 ** 2 + y1 ** 2);
    if(Number.isInteger(firstResult)){
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
    // second check
    let secondResult = Math.sqrt(x2 ** 2 + y2 ** 2);
    if(Number.isInteger(secondResult)){
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }
    else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

     // third check
    let thirdResult = Math.sqrt((x1 - x2) ** 2 + (y1 - y2) ** 2);
   
    if(Number.isInteger(thirdResult)){
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}

validChecker(3, 0, 0, 4);
validChecker(2, 1, 1, 1);