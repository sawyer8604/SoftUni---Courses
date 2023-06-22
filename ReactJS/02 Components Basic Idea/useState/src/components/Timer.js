import React from "react";

const Timer = (props) => {

    const [seconds, setSeconds] = React.useState(props.start);
    

    setTimeout(() => {
        //setSeconds(seconds + 1)
        setSeconds((state) => state+1);
    }, 1000);

    return(

        <div>
            Time: {seconds}s

        </div>
    )
}

export default Timer;