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
            <p style={{fontSize: Math.max(counter, 1) + 'em'}}>{counter === 0 ? 'Counter': title }: {counter}</p>
            {props.canReset && <button onClick={incrementCounterHandler}>+</button>}
            { counter < 10 ?
                <button onClick={decrementCounterHandler}>-</button>
                : null
                }
            <button onClick={resetCounterHandler}>0</button>


        </div>
    )
}

export default Counter;