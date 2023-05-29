function formatGrade(grade) {
   let result =' ';
    if (grade >= 5.5) {
     result = 'Excellent';
   } else if(grade >= 4.5) {
    result = 'Very good';
   } else if(grade >= 3.5) {
    result = 'Good';
   } else if(grade >= 3) {
    result = 'Poor';
   } else if(grade < 3) {
    result = 'Fail';
    console.log(`${result} (2)`);
    return;
   }

   console.log(`${result} (${grade.toFixed(2)})`);
}

formatGrade(3.33);
formatGrade(4.50);
formatGrade(2.99);