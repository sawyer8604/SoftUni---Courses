import { useState } from "react";
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
    return(

        <div>
            <h3>Counter: {counter}</h3>
            <button onClick={incrementCounterHandler}>+</button>
            <button onClick={decrementCounterHandler}>-</button>
            <button onClick={resetCounterHandler}>0</button>


        </div>
    )
}

export default Counter;