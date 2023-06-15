async function getInfo() {
    const busNumber = document.getElementById('stopId').value;
    const url = `http://localhost:3030/jsonstore/bus/businfo/${busNumber}`;
    const stopName = document.getElementById('stopName');
    const busesList = document.getElementById('buses');
    try {
        const allBusStops = await fetch(url);
        const data = await allBusStops.json();
              
        const {name, buses} = data;   
        stopName.textContent = name;      

        for (const busId in buses) {
            const li = document.createElement('li');            
            li.textContent = `Bus ${busId} arrives in ${buses[busId]} minutes`;
            busesList.appendChild(li);
        }
    } catch (error) {
        stopName.textContent = 'Error';          
    }
}