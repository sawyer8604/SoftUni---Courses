function attachEvents() {
    const name = document.querySelector('input[name="author"]');
    const message = document.querySelector('input[name="content"]');
    const submitBtn = document.getElementById('submit');
    const refreshBtn = document.getElementById('refresh');
    const textArea = document.getElementById('messages');

    submitBtn.addEventListener('click', send);
    refreshBtn.addEventListener('click', refresh);

    const url = 'http://localhost:3030/jsonstore/messenger';

    async function send(){

        const author = name.value;
        const content = message.value;
        name.value = '';
        message.value = '';
        if(author.length !== 0 || content.length !== 0){
            textArea.disabled = false;
            const httpHeaders = {
                method: 'POST',
                body: JSON.stringify({author, content})
             }
            const messages = await fetch(url, httpHeaders);
        
            textArea.value += `${author}: ${content}\n`;
        }

    }

    async function refresh(){

        const allMessages = await fetch(url);
        const data = await allMessages.json();

        textArea.value = '';  

        textArea.value = Object.values(data)
            .map(({ author, content }) => `${author}: ${content}`)
            .join("\n");      
        
    }

}

attachEvents();