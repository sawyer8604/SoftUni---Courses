function calc() {
    const firstNum = document.getElementById('num1').value;
    const secondNum = document.getElementById('num2').value;

    let num1 = Number(firstNum);
    let num2 = Number(secondNum);

    const sum = document.getElementById('sum');
    sum.value = num1 + num2;
    
}
