function phoneBook(arr){
    let phoneBooks = {};
    
    for (const info of arr) {
        let [name, phoneNumber] = info.split(' ');
        phoneBooks[name] = phoneNumber;
    }
    
    for (const key in phoneBooks) {
       console.log(`${key} -> ${phoneBooks[key]}`);
    }
}

phoneBook(['Tim 0834212554',
'Peter 0877547887',
'Bill 0896543112',
'Tim 0876566344']
);