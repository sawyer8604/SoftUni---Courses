function characterInRange(firstSymbol, secondSymbol) {
   
   let firstAsNum = firstSymbol.charCodeAt(0);
   let secondAsNum = secondSymbol.charCodeAt(0);

   let min = Math.min(firstAsNum, secondAsNum);
   let max = Math.max(firstAsNum, secondAsNum);
   let result = [];

    for (let i = min + 1; i < max; i++) {
        
        result.push(String.fromCharCode(i));
    }

    console.log(result.join(' '));
}

characterInRange('C',
'#'
);