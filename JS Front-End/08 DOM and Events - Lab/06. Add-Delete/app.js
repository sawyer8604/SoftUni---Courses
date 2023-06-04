function addItem() {
    const ulContainer = document.querySelector('#items');
    const input = document.getElementById('newItemText');
    const newLiElement = document.createElement('li');
    const newAnchor = document.createElement('a');
    newLiElement.textContent = input.value;       
    newAnchor.textContent = '[Delete]';
    newAnchor.setAttribute('href', '#');
    newAnchor.addEventListener('click', deleteHandler)
    newLiElement.appendChild(newAnchor);
    ulContainer.appendChild(newLiElement);
    input.value = '';

    function deleteHandler(e){
        const liItem = e.currentTarget.parentElement;
        liItem.remove();
    }
}