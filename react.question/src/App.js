import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {BrowserRouter as Router,  Routes , Route} from "react-router-dom";
import { UserPage } from './main/user/user-page';

function App() {
  return (
    <div className='App'>  
     <Router>
      <Routes>
        <Route path='/' element={<UserPage/>}/>
      </Routes>
    </Router>
  </div>
);

}

export default App;
