function solve(input){

    class Song{
        constructor(type, name, time){
            this.type = type;
            this.name = name;
            this.time = time;

        }
    }

    let songs = [];
    let numberOfSong = input.shift();
    let typeSong = input.pop();

    for (const line of input) {
        
        let[type, name, time] = line.split('_');
        songs.push(new Song(type, name, time));
    }

   
        if(typeSong === 'all'){
            for (const song of songs) {
                console.log(`${song.name}`);               
             }
            ;
        }else{
            let filtered = songs.filter((s) => s.type === typeSong);
            for (const s of filtered) {
               console.log(s.name);
            }
        }
    
}

solve([4,
    'favourite_DownTown_3:14',
    'listenLater_Andalouse_3:24',
    'favourite_In To The Night_3:58',
    'favourite_Live It Up_3:48',
    'listenLater']
    );

solve([3,
    'favourite_DownTown_3:14',
    'favourite_Kiss_4:16',
    'favourite_Smooth Criminal_4:01',
    'favourite']
    );