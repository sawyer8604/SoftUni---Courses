function Movie(props){
    return(

        <article>
            <h3>{props.title}</h3>
            <h5>{props.year}</h5>
            <ul>
                <li>{props.actors[0]}</li>
                <li>{props.actors[1]}</li>
            </ul>
            <p>{props.actors}</p>
            </article>
    );
}

export default Movie;