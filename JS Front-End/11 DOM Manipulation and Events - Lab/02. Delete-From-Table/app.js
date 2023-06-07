function deleteByEmail() {
    const elements = Array.from(document.querySelectorAll('tbody > tr'));
    const input = document.querySelector('input[name="email"]').value;
    const output = document.getElementById('result');
    let isDeleted = false;

    for (const row of elements) {
        const col = row.children[1];
        if(col.textContent === input){
            row.remove(); 
            isDeleted = true;
            output.textContent = 'Deleted.';        
        }
    }

    if(!isDeleted){
        output.textContent = 'Not found.'; 
    }
    
}