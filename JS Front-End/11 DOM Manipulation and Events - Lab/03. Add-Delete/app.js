function addItem() {
    const text = document.getElementById('newItemText').value;

    const newLi = document.createElement('li');    
    newLi.textContent = text;
    const anchor = document.createElement('a');
    anchor.href = '#';
    anchor.textContent = '[Delete]';
    newLi.appendChild(anchor);

    const list = document.getElementById('items');
    list.appendChild(newLi);

    anchor.addEventListener('click', () => newLi.remove());
}