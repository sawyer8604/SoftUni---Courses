function calc() {
    const firstElement = document.getElementById('num1');
    const secondElement = document.getElementById('num2');
    const sumElement = document.getElementById('sum');

    let firstNum = Number(firstElement.value);
    let secondNum = Number(secondElement.value);

    let sum = firstNum + secondNum;
   
    sumElement.value = sum;
}
