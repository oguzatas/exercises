import "./App.css";
import { Greet } from "./components/Greet";
import Welcome from "./components/Welcome";
import Yolo from "./components/Yolo";

function App() {
  return (
    <div className="App">
      <Greet />
      <Welcome />
      <Yolo />
    </div>
  );
}

export default App;
