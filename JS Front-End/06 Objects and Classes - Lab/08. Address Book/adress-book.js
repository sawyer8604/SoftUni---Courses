function addressB(input) {
    
    let addressBook = {};

    for (const line of input) {
        let[name, address] = line.split(':');
        addressBook[name] = address;
    }

    let entries = Object.entries(addressBook);

    let sortedByName = entries.sort((personA, personB) => {
        let personAName = personA[0];
        let personBName = personB[0];
    
        return personAName.localeCompare(personBName);
    });

    for (const [key, value] of sortedByName) {
        console.log(`${key} -> ${value}`)
    }
}

addressB(['Tim:Doe Crossing',
'Bill:Nelson Place',
'Peter:Carlyle Ave',
'Bill:Ornery Rd']
);