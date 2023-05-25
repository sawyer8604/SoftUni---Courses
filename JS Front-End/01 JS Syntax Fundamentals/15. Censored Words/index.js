function solve(text, word){

    let replaced = text.replace(word, '*'.repeat(word.length));

    while(replaced.includes(word)){
        replaced = replaced.replace(word, '*'.repeat(word.length));
    }

    console.log(replaced)
}

solve('A small sentence with some words small', 'small');
solve('Find the hidden word', 'hidden');