import { useState } from "react";

const getTitle = (count) => {
    switch (count) {
        case 1:
            return 'First Blood'
            
        case 2:
            return 'Double Kill'
        case 3:
            return 'Triple Kill'
        case 4:
            return 'Unstoppable'
                
        default:
            return 'Godlike'
            
    }
}



const Counter = (props) => {
    const [counter, setCounter] = useState(0);

    const incrementCounterHandler = () => {
        setCounter (counter => counter +1);
    }
    const decrementCounterHandler = () => {
        setCounter (counter => counter -1);
    }
    const resetCounterHandler = () => {
        setCounter (0);
    }

    const title = getTitle(counter);

    return(

        <div>
            <h3>{counter === 0 ? 'Counter': title }: {counter}</h3>
            <button onClick={incrementCounterHandler}>+</button>
            <button onClick={decrementCounterHandler}>-</button>
            <button onClick={resetCounterHandler}>0</button>


        </div>
    )
}

export default Counter;