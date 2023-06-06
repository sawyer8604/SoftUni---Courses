function subtract() {
    const firstNum = document.getElementById('firstNumber').value;
    const secondNum = document.getElementById('secondNumber').value;

    let numOne = Number(firstNum);
    let numTwo = Number(secondNum);

    const result = document.getElementById('result');

    result.textContent = numOne - numTwo;

}