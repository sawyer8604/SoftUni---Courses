function wordTracker(input){

    let searchedWords = input.shift().split(' ');
    let result = {};

    for (const word of searchedWords) {

        let count = input.filter((w) => w === word).length;
        result[word] = count;
    }
     
    let resultAsArray = Object.entries(result);
    
    let sortedWords = resultAsArray.sort((wordA, wordB) => {
        let [nameA, countA] = wordA;
        let [nameB, countB] = wordB;

        return countB - countA;
    });

   for (const [word, count] of sortedWords) {
    console.log(`${word} - ${count}`)
    }
   }

wordTracker([
    'this sentence', 
    'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurrences', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
    ]
    );