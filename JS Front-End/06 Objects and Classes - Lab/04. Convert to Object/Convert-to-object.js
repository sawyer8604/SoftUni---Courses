function convertToObject(text) {
    
    let person = JSON.parse(text);

    const keys = Object.entries(person);

    for (const [key, value] of keys) {
        console.log(`${key}: ${value}`)
    } 
}
convertToObject('{"name": "George", "age": 40, "town": "Sofia"}');