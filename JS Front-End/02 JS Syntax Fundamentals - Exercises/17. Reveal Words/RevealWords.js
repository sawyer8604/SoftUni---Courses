function revealWords(words, text){
    let wordsArr = words.split(', ');
    let textArr = text.split(' ');
    for (const word of wordsArr) {
        
        for (const temlate of textArr) {
            if(temlate.includes('*') && word.length === temlate.length){
                text = text.replace(temlate, word);
            }
        }
    }

    console.log(text);
}

revealWords('great',
'softuni is ***** place for learning new programming languages'
);

revealWords('great, learning',
'softuni is ***** place for ******** new programming languages'
);
