function solve(input){

    let towns = {};

    for (const line of input) {
        
        let[town, latitude, longitude] = line.split(' | ');
        latitude = Number(latitude).toFixed(2);
        longitude = Number(longitude).toFixed(2);
        towns = { town: town, latitude: latitude, longitude: longitude };
        
        console.log(towns);       
    }
}

solve(['Sofia | 42.696552 | 23.32601',
'Beijing | 39.913818 | 116.363625']
)