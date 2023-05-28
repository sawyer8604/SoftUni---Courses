function PascalCaseSplitter(text) {
    let counter = 0;
    let result = '';

    for (const symbol of text) {
       
        if(symbol === symbol.toUpperCase() && counter > 0)
        {
            result += ', ';
            result += symbol;
        }else{
            result += symbol;
        }
        counter ++;
        
    }
    console.log(result);
}

PascalCaseSplitter('SplitMeIfYouCanHaHaYouCantOrYouCan');