function sumTable() {

    /*const table = Array.from(document.getElementsByTagName('tr'));
     let sum = 0;
    for (let index = 1; index < table.length; index++) {

        let cols = table[index].children;

        let crrElement = cols[cols.length - 1].textContent;

        console.log(crrElement);
        sum += Number(crrElement);
    }
    const result = document.getElementById('sum');
    result.textContent = sum; */

    let costElements = document.querySelectorAll('tr td:nth-of-type(2)');
    let sum = Array.from(costElements).reduce((a, x) => {
        let currentValue = Number(x.textContent) ||  0;
        return a + currentValue;
    }, 0);

    let resultElement = document.getElementById('sum');
    resultElement.textContent = sum;
}