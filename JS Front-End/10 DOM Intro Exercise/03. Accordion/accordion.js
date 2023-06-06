function toggle() {
    const btn = document.getElementsByClassName('button')[0];
    const text = document.querySelector('#extra');

    if (btn.textContent === 'More'){

        text.style.display = 'block';
        btn.textContent = 'Less'
        
    } else{
        text.style.display = 'none';
        btn.textContent = 'More'

    }
    
}