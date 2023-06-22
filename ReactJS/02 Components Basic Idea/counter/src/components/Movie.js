
function Movie(props){
    console.log("Movie")

    let render = 0;

    

    return(
        
        <article>
            <h3>{props.title}</h3>
            <h5>{props.year}</h5>
            <ul>
                <li>{props.actors[0]}</li>
                <li>{props.actors[1]}</li>
            </ul>
            
            </article>
    );
}

export default Movie;