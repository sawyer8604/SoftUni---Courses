function solve(text, inputWord){
    let inputText = text.split(" ");
    let counter = 0;
    for (const word of inputText) {
        if(word === inputWord)
        {
            counter ++;
        }
    }

    console.log(counter);
}

solve('This is a word and it also is a sentence','is');
solve('softuni is great place for learning new programming languages','softuni');