function RoadRadar(speed, typeOfWay){
   let speedLimit = 0;
   
    switch (typeOfWay) {
        case 'motorway':
            speedLimit = 130;
            break;
        case 'interstate':
            speedLimit = 90;
            break;
        case 'city':
            speedLimit = 50;
            break;
        case 'residential':
            speedLimit = 20;
            break;    
    }
    let difference = speed - speedLimit;

    if(difference <= 0)
    {
        console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
    }else if(difference > 0 && difference <= 20){
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - speeding`);
    }
    else if(difference > 20 && difference <= 40){
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - excessive speeding`);
    }else{
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - reckless driving`);
    }
}

RoadRadar(40, 'city');
RoadRadar(21, 'residential');
RoadRadar(120, 'interstate');
RoadRadar(200, 'motorway');
