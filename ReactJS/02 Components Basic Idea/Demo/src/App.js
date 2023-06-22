
import './App.css';

const Heading = (props) => {
  return <h1 className = "heading">Hello from {props.title} !</h1>;
}

function App() {
  return (
    <div >
      <Heading title = {"React"}/>
      <Heading title = {"Second"}/>
      <Heading title = {"Third"}/>
      <Heading title = {"Mus"}/>
      <h2>Slogan here</h2>
      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Hic, animi?</p>
    </div>
  );
}

export default App;
