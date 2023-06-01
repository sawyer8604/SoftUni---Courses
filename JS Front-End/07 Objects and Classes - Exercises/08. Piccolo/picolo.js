function piccolo(input){

let cars = {};

for (const line of input) {
        let[direction, carNumber] = line.split(', ');
     
        if(direction === 'IN'){
            if(!cars.hasOwnProperty(carNumber)){
                cars[carNumber] = 0;
            }
        }
        if(direction === 'OUT'){
            if(cars.hasOwnProperty(carNumber)){
                delete cars[carNumber];
            }
        }
    }
    let carsAsArray = Object.keys(cars);

    let sortedCars = carsAsArray.sort((carA, carB) => {
        return carA.localeCompare(carB)
    })
    for (const car of sortedCars) {
        console.log(car)
    }


}

piccolo(['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']
);