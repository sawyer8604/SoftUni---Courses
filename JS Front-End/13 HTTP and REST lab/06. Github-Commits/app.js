async function loadCommits() {
    const username = document.getElementById('username').value;
    const repo = document.getElementById('repo').value;
    console.log(username)
    console.log(repo)

    const list = document.getElementById('commits');

    const url = `https://api.github.com/repos/${username}/${repo}/commits`;

    try{
        const allCommits = await fetch(url, {method:'GET'});
        const data = await allCommits.json();	       
        
            for (const element of data) {
                const li = document.createElement('li');
                li.textContent = `${element.commit.author.name}: ${element.commit.message}`
                list.appendChild(li);
            }
        
         } catch(err) {
            const li = document.createElement('li');
            li.textContent = `Error: ${err.status} (Not Found)`
            list.appendChild(li);
          } 
}