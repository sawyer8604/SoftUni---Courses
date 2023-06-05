function extractText() {
    const liElements = document.getElementById('items');
    const items = Array.from(liElements.children);
    
    const result = items.map((li) => li.textContent).join('\n');

    const textArea = document.getElementById('result');
    textArea.value = result;
}