function solve() {
   const searchedText = document.querySelector('#searchField');
   
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const rows = Array.from(document.querySelectorAll('tbody > tr'));
      for (const row of rows) {

         if(row.textContent.toLowerCase().includes(searchedText.value.toLowerCase())){
            row.classList.add("select");
         }else{
            row.classList.remove("select");
         }
         
      }
      searchedText = '';
   }

   /*const input = document.querySelector("#searchField");
   document.querySelector("#searchBtn").addEventListener("click", onClick);
 
   function onClick() {
     Array.from(document.querySelectorAll("tbody tr")).forEach((row) => {
       if (
         row.textContent.toLowerCase().includes(input.value.toLowerCase().trim())
       ) {
         row.classList.add("select");
       } else {
         row.classList.remove("select");
       }
     });
     input.value = "";
   } */
}