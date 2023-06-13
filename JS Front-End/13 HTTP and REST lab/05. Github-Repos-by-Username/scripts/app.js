async function loadRepos() {
	const username = document.getElementById('username').value;
	const url = `https://api.github.com/users/${username}/repos`;
	const repos = document.getElementById('repos');

	try{
	const allRepos = await fetch(url, {method:'GET'});
	const data = await allRepos.json();	
	repos.replaceChildren();
	
		for (const element of data) {
			const li = document.createElement('li');
			li.innerHTML = `<a href="${element.html_url}">${element.full_name}</a>`;
			repos.appendChild(li);
		}
	
	 } catch(err) {
		repos.innerHTML = `<p>${err}</p>`;
	  } 
}