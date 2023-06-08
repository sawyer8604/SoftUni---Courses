function create(words) {
   const parentDiv = document.getElementById('content');

   for (const word of words) {
      
      const div = document.createElement('div');
      const p = document.createElement('p');
      p.textContent = word;
      div.appendChild(p);
      parentDiv.appendChild(div);
      p.style.display = 'none'; 
      
      div.addEventListener('click', showText);
   }

   function showText(event){
      const element = event.target.querySelector('p');
      element.style.display = 'block';
   }

}