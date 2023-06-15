function solve() {

    let nextStop = 'depot';
    let url = `http://localhost:3030/jsonstore/bus/schedule/`;
    const info = document.querySelector('#schedule div span');
    const departBtn = document.getElementById('depart');
    const arrivedBtn = document.getElementById('arrive');   

    async function depart() {       
        try {
            
            departBtn.disabled = true;
            arrivedBtn.disabled = false;

            const allStops = await fetch(url + nextStop);
            const data = await allStops.json();       
           
            info.textContent = `Next stop ${data.name}`;              

        } catch (error) {
            
        }
        
    }

    async function arrive() {        
        try {

            arrivedBtn.disabled = true;
            departBtn.disabled = false;

            const allStops = await fetch(url + nextStop);
            const data = await allStops.json();                    
            info.textContent = `Arriving at ${data.name}`;
            nextStop = data.next;
            
        } catch (error) {
            
        }
        
    }

    return {
        depart,
        arrive
    };
}

let result = solve();