function ArrayRotation(arr, rotation){
let numberOfRotation = rotation % arr.length;

for (let i = 0; i < numberOfRotation; i++) {
    let crrElement = arr.shift();
    arr.push(crrElement);    
}

console.log(arr.join(' '));
}

ArrayRotation([51, 47, 32, 61, 21], 2);
ArrayRotation([32, 21, 61, 1], 4);