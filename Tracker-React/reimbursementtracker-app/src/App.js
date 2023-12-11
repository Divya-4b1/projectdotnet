import logo from './logo.svg';
import './App.css';
import AddUserProfile from './components/AddUserProfile';
import UserProfiles from './components/UserProfiles';
import RegisterUser from './components/RegisterUser';
import LoginUser from './components/LoginUser';
import AddRequest from './components/AddRequest';
import Requests from './components/Requests';
import Expenses from './components/Expenses';
import Payments from './components/Payments';

function App() {
  return (
    <div className="App">
      <div className="container text-center">
        <div className="row">
          <div className="col">
           <UserProfiles/>
          </div>
          <div className="col">
          <AddUserProfile/> 
          </div>
          <div className="col">
          <RegisterUser/>  
          </div>
          <div className="col">
          <LoginUser/>   
          </div>
          <div className="col">
          <AddRequest/>   
          </div>
          <div className="col">
          <Requests/>   
          </div>
          <div className="col">
          <Expenses/>   
          </div>
          <div className="col">
          <Payments/>   
          </div>
        </div>
     </div>
    </div>
  );
}

export default App;
