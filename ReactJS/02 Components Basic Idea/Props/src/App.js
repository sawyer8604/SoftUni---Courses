import './App.css';
import MovieList from './components/MovieList';

function App() {

  const movies = [
    {title: 'Lord Of the Rings', year: 2001, cast: ['Frodo', 'Sam', 'Pip']},
    {title: 'Harry Potter', year: 2003, cast: ['Harry', 'Ron', 'Emma']},
    {title: 'Matrix', year: 1999, cast: ['Neo', 'Morpheus', 'Trinity']}
  ]
  console.log("App");
     
  return (
    <div className = "App">
      
      <MovieList movies={movies}/>
      
    </div>
  );
}

export default App;
