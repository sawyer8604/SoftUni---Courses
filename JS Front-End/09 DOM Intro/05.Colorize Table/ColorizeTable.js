function colorize() {
    let rowElements = Array.from(document.getElementsByTagName('tr'));
      
    for (let index = 0; index < rowElements.length; index++) {
        if(index % 2 !== 0){
            rowElements[index].style.backgroundColor = 'teal';
        }
        
    }

    /*rowElements.forEach((x, i) => {
        if (i % 2 != 0){
            x.style.backgroundColor = 'teal';
        }
    });*/
}