function substring(word, text) {
    
    let words = word.toLowerCase();
    let textArray = text.split(" ");

    for (const text of textArray) {
        if(words === text.toLowerCase()){
            console.log(words);
            return;
        }
        
    }
    console.log(`${word} not found!`);
}

substring('javascript',
'JavaScript is the best programming language'
);