function attachEvents() {
  
  const getFirstName = document.querySelector('input[name="firstName"]');
  const getLastName = document.querySelector('input[name="lastName"]');
  const getFacultyNumber = document.querySelector('input[name="facultyNumber"]');
  const getGrade = document.querySelector('input[name="grade"]');
  const tableBody = document.getElementsByTagName('tbody')[0];
  const submitBtn = document.getElementById('submit');

  submitBtn.addEventListener('click', addStudents);
  window.addEventListener("load", getAllStudents);

  const url = 'http://localhost:3030/jsonstore/collections/students';
    
  async function getAllStudents(){

    const allStudents = await fetch(url);
    const data = await allStudents.json();
    
   for (const text in data) {    
  
    const crrStudent = data[text];
    const tr = document.createElement('tr');
    const tdFirst = document.createElement('td');
    tdFirst.textContent = crrStudent.firstName;
    tr.appendChild(tdFirst);
    const tdSecond = document.createElement('td');
    tdSecond.textContent = crrStudent.lastName;
    tr.appendChild(tdSecond);
    const tdThird = document.createElement('td');
    tdThird.textContent = crrStudent.facultyNumber;
    tr.appendChild(tdThird);
    const tdFourth = document.createElement('td');
    tdFourth.textContent = crrStudent.grade;
    tr.appendChild(tdFourth);
    tableBody.appendChild(tr);

   }
  }
  
  async function addStudents(){

    const firstName = getFirstName.value;
    const lastName = getLastName.value;
    const facultyNumber = getFacultyNumber.value;
    const grade = getGrade.value;

    getFirstName.value = '';
    getLastName.value = '';
    getFacultyNumber.value = '';
    getGrade.value = '';
    const httpHeaders = {
      method: 'POST',
      body: JSON.stringify({firstName, lastName, facultyNumber, grade})
    };  

    if(firstName.length > 0 && lastName.length > 0 && facultyNumber.length > 0 && grade.length > 0){

      fetch (url, httpHeaders)
      .then ((res) => res.json())
      .then(getAllStudents)
      .catch((err) => {
          console.error(err);
      })
    }

    
  }

}


attachEvents();