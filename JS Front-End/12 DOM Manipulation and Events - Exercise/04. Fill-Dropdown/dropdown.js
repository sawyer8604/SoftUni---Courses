function addItem() {
    const textItem = document.getElementById('newItemText');
    const textValue = document.getElementById('newItemValue');

    const option = document.createElement('option');
    option.value = textValue.value;
    option.textContent = textItem.value;

    const menu = document.getElementById('menu');

    menu.appendChild(option);

    textValue.value = '';
    textItem.value = '';
}