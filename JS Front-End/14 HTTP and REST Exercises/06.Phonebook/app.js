function attachEvents() {
    const loadButton = document.getElementById('btnLoad');
    const createButton = document.getElementById('btnCreate');
    const url = 'http://localhost:3030/jsonstore/phonebook';
    const listPhoneBook = document.getElementById('phonebook');

    const personInput = document.getElementById('person');
    const phoneInput = document.getElementById('phone');

    loadButton.addEventListener('click', loading);
    createButton.addEventListener('click', createPhone);


    async function loading(){

        listPhoneBook.textContent = '';
        const phoneBookEntries = await fetch(url);
        const data = await phoneBookEntries.json();

        for (const text in data) {
            const value = data[text];

            const{person, phone, _id} = value;

            const li = document.createElement('li');
            li.textContent = `${person}: ${phone}`;
            const button = document.createElement('button');
            button.textContent = 'Delete';
            button.id = _id;
            li.appendChild(button);
            listPhoneBook.appendChild(li);
            button.addEventListener('click', deleted);
        }

    }

    function deleted(event){
        
        const id = this.id;
        const httpHeaders = {
            method: 'DELETE'
        };

        fetch (`${url}/${id}`, httpHeaders)
        .then ((res) => res.json())
        .then(loading)
        .catch((err) => {
            console.error(err);
        })

    }

    function createPhone(){
        const person = personInput.value;
        const phone = phoneInput.value;
        personInput.value = '';
        phoneInput.value = '';

        if(person.length > 0 || phone.length > 0){

            const httpHeaders = {
                method: 'POST',
                body: JSON.stringify({person, phone})
            };
    
            fetch (url, httpHeaders)
            .then ((res) => res.json())
            .then (loading)
            .catch((err) => {
                console.error(err);
            })
        }

    }

}

attachEvents();