function dictionary(input){
    let result = {};
    for (const line of input) {
        let obj = JSON.parse(line);
        
        let key = Object.keys(obj)[0];
        let value = Object.values(obj)[0];
        result[key] = value;
        
    }

    let resultAsArray = Object.entries(result);

    let sortedByTerms = resultAsArray.sort((termA, termB) => {

        let termAName = termA[0];
        let termBName = termB[0];
        return termAName.localeCompare(termBName);
    })

    for (const [key, value] of sortedByTerms) {
        console.log(`Term: ${key} => Definition: ${value}`)
    }
   
}

dictionary([
    '{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',
    '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
    '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
    '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
    '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}'
    ]
    );