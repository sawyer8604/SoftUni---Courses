function attachEvents() {
    const submitBtn = document.getElementById('submit');
    submitBtn.addEventListener('click', getWeather);
    const url = 'http://localhost:3030/jsonstore/forecaster/locations';   

    const forecast = document.getElementById('forecast');
    const crrDiv = document.getElementById('current');   
    const upComing = document.getElementById('upcoming');      
  
    let crrCode = '';
    let crrName = '';
    let isInclude = false;

    const conditions = {
        Sunny: "&#x2600", // ☀
        "Partly sunny": "&#x26C5", // ⛅
        Overcast: "&#x2601", // ☁
        Rain: "&#x2614", // ☂
        Degrees: "&#176", // °
      };    

    
    async function getWeather(){
        const location = document.getElementById('location');
        const locationText = location.value;  
        forecast.style.display = 'block';

        try {
           
            const towns = await fetch(url);
            const data = await towns.json();
            
            for (const town of data) {   
                const {name, code} = town;
                
               if(locationText === name){
                crrCode = code;
                crrName = name;
                isInclude = true;                
               }
               
            }
          
            if(!isInclude){                

                throw new Error();

            } else{
                // Today
                const todayUrl = `http://localhost:3030/jsonstore/forecaster/today/${crrCode}`; 

                    const towns = await fetch(todayUrl);
                    const data = await towns.json();
                    const {name, forecast} = data;
                    const {condition, high, low} = forecast;

                    const firstDiv = document.createElement('div');
                    firstDiv.setAttribute('class', 'forecasts');

                    const firstSpan = document.createElement('span');
                    firstSpan.setAttribute('class', 'condition symbol');
                    firstSpan.innerHTML = conditions[data.forecast.condition];  
                    firstDiv.appendChild(firstSpan);                  

                    const secondSpan = document.createElement('span');
                    secondSpan.setAttribute('class', 'condition');
                    secondSpan.innerHTML = `<span class="forecast-data">${name}</span>\n<span class="forecast-data">${low}°/${high}°</span>\n<span class="forecast-data">${condition}</span>`;
                    
                    firstDiv.appendChild(secondSpan);                    

                    crrDiv.appendChild(firstDiv);                   

                    // three-day 
                    
                    const threeUrl = `http://localhost:3030/jsonstore/forecaster/upcoming/${crrCode}`; 

                    const townsUpcoming = await fetch(threeUrl);
                    const dataUpcoming = await townsUpcoming.json();
                    
                    let townName = dataUpcoming.name;
                    let townForecast = dataUpcoming.forecast;

                    const secondDiv = document.createElement('div');
                    secondDiv.className = 'forecast-info';
                  
                    for (const town of townForecast) {
                       let townCondition = town.condition;
                       let townHigh = town.high;
                       let townLow = town.low;

                       const upcomingSpan = document.createElement('span');
                       upcomingSpan.className = 'upcoming';

                       upcomingSpan.innerHTML = `<span class="symbol">${conditions[data.forecast.condition]}</span>\n<span class="forecast-data">${townLow}&#176/${townHigh}°</span>\n<span class="forecast-data">${townCondition}</span>`;
                       secondDiv.appendChild(upcomingSpan);
                    }                    

                    upComing.appendChild(secondDiv);
                    
                }            
            
        } catch (error) {
            forecast.textContent = "Error";
        }
    }

}

attachEvents();