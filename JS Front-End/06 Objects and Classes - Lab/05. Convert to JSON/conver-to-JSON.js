function convertToJSON(name, lastName, hairColor) {
    let person = {name, lastName, hairColor};

    let personAsJson = JSON.stringify(person);

    console.log(personAsJson);
}

convertToJSON('Peter', 'Smith', 'Blond');