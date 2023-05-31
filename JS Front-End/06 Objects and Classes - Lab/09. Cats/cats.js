function solve(input) {
    
    class Cat {

        constructor(name, age)
        {
            this.name = name;
            this.age = age;
        } 
        
        meow(){
            console.log(`${this.name}, age ${this.age} says Meow`)
        }
    }
    let allcats = [];
    for (const line of input) {
        
        let [name, age] = line.split(' ');
        age = Number(age);
        allcats.push(new Cat(name, age));
    }

    for (const cat of allcats) {
        cat.meow();
    }
}

solve(['Mellow 2', 'Tom 5']);