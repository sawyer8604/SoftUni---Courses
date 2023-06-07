function focused() {
   
    const elements = Array.from(document.querySelectorAll('input'));
        
    for (const element of elements) {
        element.addEventListener('focus', () => {
            element.parentElement.className = 'focused'
        });
        element.addEventListener('blur', () => {
            element.parentElement.className = ''
        });
    }
    
}