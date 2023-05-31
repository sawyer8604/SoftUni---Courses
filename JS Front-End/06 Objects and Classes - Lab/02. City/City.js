function city(objects) {
    
    const keys = Object.keys(objects);

    for (const key of keys) {
        console.log(`${key} -> ${objects[key]}`);
    }
}

city({
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000"
}
);