function search() {
   const searchedText = document.querySelector('#searchText');
   const towns = Array.from(document.querySelectorAll('#towns > li'));
   let counter = 0;

   const result = document.getElementById('result');

   /*for (const town of towns) {
      if(town.textContent.includes(searchedText)){
         counter++;
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
      }else{
         town.style.fontWeight = 'normal';
         town.style.textDecoration = 'none';
      }
      
   } */

   towns.forEach(town => {
      if(town.textContent.includes(searchedText.value)){         
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
         counter++;
      }else{
         town.style.fontWeight = 'normal';
         town.style.textDecoration = 'none';
      }
   })
   
   
   result.textContent = `${counter} matches found`

}
