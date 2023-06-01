function solve(input){

    for (const line of input) {
        console.log(`Name: ${line} -- Personal Number: ${line.length}`);
    }
}

solve([
'Silas Butler',
'Adnaan Buckley',
'Juan Peterson',
'Brendan Villarreal'
]
);