import './App.css';
import MovieList from './components/MovieList';
import Timer from './components/Timer';

function App() {

  const movies = [
    {title: 'Lord Of the Rings', year: 2001, cast: ['Frodo', 'Sam', 'Pip']},
    {title: 'Harry Potter', year: 2003, cast: ['Harry', 'Ron', 'Emma']},
    {title: 'Matrix', year: 1999, cast: ['Neo', 'Morpheus', 'Trinity']}
  ]
  console.log("App");
     
  return (
    <div className = "App">
      <h1>Timer</h1>
      <Timer start = {5} />
      <Timer start = {50} />
      <Timer start = {0} />
      
      <MovieList movies={movies}/>
      
    </div>
  );
}

export default App;
