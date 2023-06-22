import Movie from "./Movie"
const MovieList = (props) => {
    console.log("MovieList")
    return (
        <div>
            <h1>Movie List</h1>
      
            <Movie
                 title={props.movies[0].title}
                 year= {props.movies[0].year}
                 actors = {props.movies[0].cast}
             />

             <Movie
                 title={props.movies[1].title}
                 year= {props.movies[1].year}
                 actors = {props.movies[1].cast}
             />

            <Movie
              title={props.movies[2].title}
              year= {props.movies[2].year}
                 actors = {props.movies[2].cast}
             /> 
         </div>
    )
};

export default MovieList;