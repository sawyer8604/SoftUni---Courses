function addItem() {
    
    const text = document.getElementById('newItemText').value;

    const newLi = document.createElement('li');    
    newLi.textContent = text;

    const list = document.getElementById('items');
    list.appendChild(newLi);

   }