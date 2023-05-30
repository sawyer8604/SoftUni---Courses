function passwordValidator(input) {
       
        let lettersAndDigitsPattern = /^[A-Za-z0-9]+$/g;
        let twoDigits = /[0-9]{2}/g;

        let isValid = true;
        let isOnlyLettersAndDigits = lettersAndDigitsPattern.test(input);
        let isHaveTwoDigits = twoDigits.test(input);
        
        let inputAsArray = [...input];

        if(!(inputAsArray.length >= 6 && input.length <= 10)){
            console.log('Password must be between 6 and 10 characters');
            isValid = false;
        }

        if(!isOnlyLettersAndDigits){
            console.log('Password must consist only of letters and digits');
            isValid = false;            
        }
        
        if(!isHaveTwoDigits){
            console.log('Password must have at least 2 digits');
            isValid = false;            
        }

        if(isValid){
            console.log('Password is valid');
        }
}

passwordValidator('MyPass123');
passwordValidator('logIn');
passwordValidator('Pa$s$s');