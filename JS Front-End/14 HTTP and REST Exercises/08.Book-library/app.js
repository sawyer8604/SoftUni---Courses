function attachEvents() {
  
  const loadAllBooks = document.getElementById('loadBooks');
  const tableBody = document.querySelector('table tbody');
  const submitBtn = document.querySelector('#form button');
  const formHeader = document.querySelector('#form h3');
  const getTitle = document.querySelector('#form input[name="title"]');
  const getAuthor = document.querySelector('#form input[name="author"]');

  const url = 'http://localhost:3030/jsonstore/collections/books/';

  let editBookId = '';

  loadAllBooks.addEventListener('click', loadBooks);

  async function loadBooks(){

    const allBooks = await fetch(url);
    const data = await allBooks.json();
    tableBody.textContent = '';
   
    for (const bookId in data) {
      
      const book = data[bookId]; 
      
      const tr = document.createElement('tr');
      const firstTd = document.createElement('td');
      firstTd.textContent = book.author; 
      tr.appendChild(firstTd);

      const secondTd = document.createElement('td');
      secondTd.textContent = book.title; 
      tr.appendChild(secondTd);

      const thirdTd = document.createElement('td');
      const editBtn = document.createElement('button');
      editBtn.textContent = 'Edit';
      editBtn.id = bookId;
      thirdTd.appendChild(editBtn);
      const deleteBtn = document.createElement('button');
      deleteBtn.textContent = 'Delete';
      deleteBtn.id = bookId;
      deleteBtn.addEventListener('click', deleteBookHandler);
      thirdTd.appendChild(deleteBtn);
      
      tr.appendChild(thirdTd);

      tableBody.appendChild(tr);       
      
      editBtn.addEventListener('click', ()=>{
        editBookId = bookId;
        submitBtn.textContent = 'Save';
        formHeader.textContent = 'Edit FORM';
        getTitle.value = book.title;
        getAuthor.value = book.author;

      })

    }
  }
  
  submitBtn.addEventListener('click', createBook);  

  async function createBook(){

    const title = getTitle.value;
    const author = getAuthor.value;  
    
    if(author.length > 0 && title.length > 0){
      const httpHeaders = {
        method: 'POST',
        body: JSON.stringify({author, title})
      }
      let newUrl = url;
      if(formHeader.textContent === 'Edit FORM'){
        httpHeaders.method = 'PUT';
        newUrl += editBookId;     
      }
  
      const restData = await fetch(newUrl, httpHeaders);
      loadBooks();
      
      if(formHeader.textContent === 'Edit FORM'){
          submitBtn.textContent = 'Submit';
          formHeader.textContent = 'FORM';
      }
      
  
      getTitle.value = '';
      getAuthor.value = '';

    }
    
    


  } 

  async function deleteBookHandler(event){

    const id = this.id;    
    const httpHeaders = {
      method: 'DELETE'
    }

    await fetch(url + id, httpHeaders);
    loadBooks();

  }

}

attachEvents();