function addItem() {
    const ulContainer = document.querySelector('#items');
    const input = document.getElementById('newItemText');
    const newLiElement = document.createElement('li');
    
    newLiElement.textContent = input.value;  
    ulContainer.appendChild(newLiElement); 
    input.value = '';
    
}