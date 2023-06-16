function attachEvents() {
    const postButton = document.getElementById('btnLoadPosts');    
    const viewButton = document.getElementById('btnViewPost');
    const selectPosts = document.getElementById('posts');

    postButton.addEventListener('click', posts);
    viewButton.addEventListener('click' , view);   
    
    const POST_URL = 'http://localhost:3030/jsonstore/blog/posts';
    const COMMENTS_URL = 'http://localhost:3030/jsonstore/blog/comments';

    let postsArr = [];

    async function posts(){
        try {
            const allPosts = await fetch(POST_URL);
            if (!allPosts.ok) throw new Error();
            const data = await allPosts.json();  
            document.getElementById("posts").innerHTML = ""; 
    
            for (const key in data) {
              
                let value = data[key];
                const {body, id, title}  = value;
    
                const option = document.createElement('option');
                option.value = key;
                option.textContent = title; 
                selectPosts.appendChild(option);
                postsArr.push({ id: id, title: title, body: body})
            }    
            
        } catch (error) {
            console.log(error);
        }
    }

    async function view(){
         try {
            const allComments = await fetch(COMMENTS_URL);
        if (!allComments.ok) throw new Error();
        const data = await allComments.json();

        const selectedElement = document.getElementById('posts').value;
        const h1 = document.getElementById('post-title');
        const p = document.getElementById('post-body');
        const list = document.getElementById('post-comments');        
        
        for (const key in data) {
            
            let comments = data[key];
            let commentsId = comments.id;
            let postId = comments.postId;
            let text = comments.text;

            if(selectedElement === postId){
                let element = postsArr.filter((x) => x.id === selectedElement);
                const{id, title, body} = element[0];
                h1.textContent = title;
                p.textContent = body;

                let textAsArr = text.split('! ');
                list.textContent = '';

                for (const crrText of textAsArr) {
                    const li = document.createElement('li');                    
                    li.textContent = crrText;
                    list.appendChild(li);   
                }

            }

        }
            
         } catch (error) {
            console.log(error);
         }
    }

}
attachEvents();