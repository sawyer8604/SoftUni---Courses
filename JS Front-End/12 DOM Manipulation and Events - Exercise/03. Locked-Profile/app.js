function lockedProfile() {
    const buttons = Array.from(document.getElementsByTagName('button'));

    for (const button of buttons) {
        button.addEventListener('click', showMore)
    }

    function showMore(event){

        const parent = event.target.parentElement;
        const unlock = parent.querySelector('input[value="unlock"]');

        if(unlock.checked){

            const hiddenText = parent.querySelector('div');
            
            const btn = parent.querySelector('button');

            if(btn.textContent === 'Show more'){
                hiddenText.style.display = 'block';                
                btn.textContent = 'Hide it';                
            } else if(btn.textContent === 'Hide it'){
                btn.textContent = 'Show more'; 
                hiddenText.style.display = 'none';
            }

        }
    }

}