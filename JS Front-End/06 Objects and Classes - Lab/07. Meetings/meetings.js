function meetings(meeting) {
    
    let meetingAsObj = {};

    for (const line of meeting) {
        let  [day, name] = line.split(' ');

        if(!meetingAsObj.hasOwnProperty(day)){
            meetingAsObj[day] = name;
            console.log(`Scheduled for ${day}`);            
        }else{
            console.log(`Conflict on ${day}!`);
        }
    }

    for (const key in meetingAsObj) {
      console.log(`${key} -> ${meetingAsObj[key]}`);
    }
}

meetings(['Monday Peter',
'Wednesday Bill',
'Monday Tim',
'Friday Tim']
);