function loginBar(number){

    let isComplete = number / 10 === 10;

    if(isComplete){
        console.log('100% Complete!');
        console.log(`[${'%'.repeat(10)}]`);
    }else{
        console.log(`${number}% [${'%'.repeat(number/10)}${'.'.repeat(100/10 - number/10)}]`);
        console.log('Still loading...');
    }
    
}

loginBar(100);
loginBar(50);