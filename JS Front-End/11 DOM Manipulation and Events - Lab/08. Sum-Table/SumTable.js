function sumTable() {

    const allValues = document.querySelectorAll('tbody tr td:nth-child(2)');
    const sum = document.getElementById('sum');
    let result = 0;

    for (let index = 0; index < allValues.length - 1; index++) {
        
        result += Number(allValues[index].textContent);        
        
    }
    sum.textContent = result;
}