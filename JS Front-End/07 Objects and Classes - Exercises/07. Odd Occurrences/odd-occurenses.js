function oddOccurenses(text){
    let textAsArray = text.split(' ');
    let lowerCaseArray = textAsArray.map((x) => x.toLowerCase());

    let words = {};
    let uniqueWords = new Set(lowerCaseArray);

    for (const word of uniqueWords) {
        let count = (lowerCaseArray.filter((w) => w === word)).length;
        words[word] = count;
    }

    let result = '';
    for (const key in words) {
        if(words[key] % 2 !== 0){
            result += key + ' ';
        }
    }

    console.log(result);
}

oddOccurenses('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');